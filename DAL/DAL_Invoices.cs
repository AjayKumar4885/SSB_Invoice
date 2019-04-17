using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Invoices
    {

        public Invoice GetInvoiceById(Invoice_RQ _objInvoice)
        {
            if (_objInvoice.InvoiceId > 0)
            {

                var result = GetInvoiceGeneric(_objInvoice);
            }
            return new Invoice() { };
        }
        public DataSet GetInvoiceToPrint(Invoice_RQ _objInvoice)
        {
            DataSet dsInvoice = new DataSet();

            if (_objInvoice.InvoiceId > 0)
            {
                var result = GetInvoiceGeneric(_objInvoice);
                if (result != null)
                {
                    DataTable dtInvoice = new DataTable();
                    dtInvoice.Columns.Add("InvoiceId");
                    dtInvoice.Columns.Add("InvoiceNo");
                    dtInvoice.Columns.Add("PartyNo");
                    dtInvoice.Columns.Add("BankId");
                    dtInvoice.Columns.Add("Unit");
                    dtInvoice.Columns.Add("InvoiceDate");
                    dtInvoice.Columns.Add("InvoiceCurrency");
                    dtInvoice.Columns.Add("InvoiceGrandQty");
                    dtInvoice.Columns.Add("InvoiceGrandAmt");
                    dtInvoice.Columns.Add("Remark");
                    dtInvoice.Columns.Add("DeliveryTerms");
                    dtInvoice.Columns.Add("DeliveryType");
                    dtInvoice.Columns.Add("Port");
                    dtInvoice.Columns.Add("PaymentTerms");
                    dtInvoice.Columns.Add("DeliveryPeriod");
                    dtInvoice.Columns.Add("WODelivery");
                    dtInvoice.Columns.Add("Remarks");
                    dtInvoice.Columns.Add("WORemarks");
                    dtInvoice.Columns.Add("Note");
                    dtInvoice.Columns.Add("PartialShip");
                    dtInvoice.Columns.Add("TransShipment");
                    #region Invoice
                    DataRow dtrowInvoice = dtInvoice.NewRow();
                    dtrowInvoice["InvoiceId"] = result.InvoiceId;
                    dtrowInvoice["InvoiceNo"] = result.InvoiceNo;
                    dtrowInvoice["PartyNo"] = result.PartyNo;
                    dtrowInvoice["BankId"] = result.BankId;
                    dtrowInvoice["Unit"] = result.Unit;
                    dtrowInvoice["InvoiceDate"] = result.InvoiceDate;
                    dtrowInvoice["InvoiceCurrency"] = result.InvoiceCurrency;
                    dtrowInvoice["InvoiceGrandQty"] = result.InvoiceGrandQty;
                    dtrowInvoice["InvoiceGrandAmt"] = result.InvoiceGrandAmt;
                    dtrowInvoice["Remark"] = result.Remark;
                    dtrowInvoice["DeliveryTerms"] = result.DeliveryTerms;
                    dtrowInvoice["DeliveryType"] = result.DeliveryType;
                    dtrowInvoice["Port"] = result.Port;
                    dtrowInvoice["PaymentTerms"] = result.PaymentTerms;
                    dtrowInvoice["DeliveryPeriod"] = result.DeliveryPeriod;
                    dtrowInvoice["WODelivery"] = result.WODelivery;
                    dtrowInvoice["Remarks"] = result.Remarks;
                    dtrowInvoice["WORemarks"] = result.WORemarks;
                    dtrowInvoice["Note"] = result.Note;
                    dtrowInvoice["PartialShip"] = result.PartialShip;
                    dtrowInvoice["TransShipment"] = result.TransShipment;
                    dtInvoice.Rows.Add(dtrowInvoice);
                    dsInvoice.Tables.Add(dtInvoice);
                    #endregion


                    #region DataTable for Invoice item
                    DataTable dtInvoiceItem = new DataTable();
                    dtInvoiceItem.Columns.Add("invoiceOrderItemId");
                    dtInvoiceItem.Columns.Add("ArtId");
                    dtInvoiceItem.Columns.Add("ArtNo");
                    dtInvoiceItem.Columns.Add("Desc");
                    dtInvoiceItem.Columns.Add("WorkOrderDesc");
                    dtInvoiceItem.Columns.Add("RefillsLink");
                    dtInvoiceItem.Columns.Add("Rate");
                    dtInvoiceItem.Columns.Add("Qty");
                    dtInvoiceItem.Columns.Add("Amount");
                    dtInvoiceItem.Columns.Add("Sequence");
                    dtInvoiceItem.Columns.Add("RefillsLinkId");
                    if (result._objOrderItem != null && result._objOrderItem.Count() > 0)
                    {
                        foreach (var item in result._objOrderItem)
                        {
                            DataRow dr = dtInvoiceItem.NewRow();
                            dr["invoiceOrderItemId"] = item.InvoiceItemID;
                            dr["ArtId"] = item.ArtNo;
                            dr["ArtNo"] = item.ArtNo;
                            dr["Desc"] = item.ArtDesc;
                            dr["WorkOrderDesc"] = item.WorkOrderDesc;
                            dr["RefillsLink"] = item.RefileInk;
                            dr["Rate"] = item.Rate;
                            dr["Qty"] = item.Quantity;
                            dr["Amount"] = item.Amount;
                        }
                    }
                    dsInvoice.Tables.Add(dtInvoiceItem);
                    #endregion

                }
            }
            return dsInvoice;
        }

        public Invoice GetInvoiceGeneric(Invoice_RQ _objInvoice)
        {

            using (LocalEntity _context = new LocalEntity())
            {
                //var search = _context.tblCustomers.();
                var search = (from x in _context.tblInvoices
                              where x.InvoiceId == _objInvoice.InvoiceId
                              select x).AsQueryable();
                string strInvoiceNo = string.Empty;

                if (search != null)
                {
                    strInvoiceNo = (from x in search select x.InvoiceNo).FirstOrDefault();
                }

                List<InvoiceItemDetails> _lstOrderitem = new List<InvoiceItemDetails>();
                if (strInvoiceNo != string.Empty)
                {
                    _lstOrderitem = (from x in _context.tbl_InvoiceItemDetails
                                     where x.InvoiceNo == strInvoiceNo
                                     select new InvoiceItemDetails
                                     {
                                         InvoiceItemID = x.InvoiceItemID,
                                         Amount = x.Amount,
                                         ArtDesc = x.ArtDesc,
                                         ArtNo = x.ArtNo,
                                         InvoiceNo = x.InvoiceNo,
                                         Quantity = x.Quantity,
                                         Rate = x.Rate,
                                         RefileInk = x.RefileInk,
                                         WorkOrderDesc = x.WorkOrderDesc
                                     }
                                     ).ToList();

                }
                //var itemorderdetails

                var result = (from s in search
                              select new Invoice
                              {
                                  InvoiceId = s.InvoiceId,
                                  InvoiceNo = s.InvoiceNo,
                                  PartyNo = s.PartyNo,
                                  BankId = s.BankId,
                                  Unit = s.Unit,
                                  InvoiceDate = s.InvoiceDate,
                                  InvoiceCurrency = s.InvoiceCurrency,
                                  InvoiceGrandQty = s.InvoiceGrandQty,
                                  InvoiceGrandAmt = s.InvoiceGrandAmt,
                                  Remark = s.Remark,
                                  DeliveryTerms = s.DeliveryTerms,
                                  DeliveryType = s.DeliveryType,
                                  Port = s.Port,
                                  PaymentTerms = s.PaymentTerms,
                                  DeliveryPeriod = s.DeliveryPeriod,
                                  WODelivery = s.WODelivery,
                                  Remarks = s.Remarks,
                                  WORemarks = s.WORemarks,
                                  Note = s.Note,
                                  PartialShip = s.PartialShip,
                                  TransShipment = s.TransShipment,
                                  CreatedBy = s.CreatedBy,
                                  CreatedOn = s.CreatedOn,
                                  EditedBy = s.EditedBy,
                                  EditedOn = s.EditedOn,
                                  IsActive = s.IsActive,
                                  _objOrderItem = _lstOrderitem
                              }).FirstOrDefault();
                return result;
            }
        }
        public Invoice GetInvoiceByNo(Invoice_RQ _objInvoice)
        {
            if (!string.IsNullOrWhiteSpace(_objInvoice.InvoiceNo))
            {
                try
                {
                    using (LocalEntity _context = new LocalEntity())
                    {
                        //var search = _context.tblCustomers.();
                        var search = (from x in _context.tblInvoices
                                      where x.InvoiceNo == _objInvoice.InvoiceNo
                                      select x).AsQueryable();
                        string strInvoiceNo = string.Empty;

                        if (search != null)
                        {
                            strInvoiceNo = (from x in search select x.InvoiceNo).FirstOrDefault();
                        }

                        List<InvoiceItemDetails> _lstOrderitem = new List<InvoiceItemDetails>();
                        if (strInvoiceNo != string.Empty)
                        {
                            _lstOrderitem = (from x in _context.tbl_InvoiceItemDetails
                                             where x.InvoiceNo == strInvoiceNo
                                             select new InvoiceItemDetails
                                             {
                                                 InvoiceItemID = x.InvoiceItemID,
                                                 Amount = x.Amount,
                                                 ArtDesc = x.ArtDesc,
                                                 ArtNo = x.ArtNo,
                                                 InvoiceNo = x.InvoiceNo,
                                                 Quantity = x.Quantity,
                                                 Rate = x.Rate,
                                                 RefileInk = x.RefileInk,
                                                 WorkOrderDesc = x.WorkOrderDesc
                                             }
                                             ).ToList();

                        }
                        //var itemorderdetails

                        var result = (from s in search
                                      select new Invoice
                                      {
                                          InvoiceId = s.InvoiceId,
                                          InvoiceNo = s.InvoiceNo,
                                          PartyNo = s.PartyNo,
                                          BankId = s.BankId,
                                          Unit = s.Unit,
                                          InvoiceDate = s.InvoiceDate,
                                          InvoiceCurrency = s.InvoiceCurrency,
                                          InvoiceGrandQty = s.InvoiceGrandQty,
                                          InvoiceGrandAmt = s.InvoiceGrandAmt,
                                          Remark = s.Remark,
                                          DeliveryTerms = s.DeliveryTerms,
                                          DeliveryType = s.DeliveryType,
                                          Port = s.Port,
                                          PaymentTerms = s.PaymentTerms,
                                          DeliveryPeriod = s.DeliveryPeriod,
                                          WODelivery = s.WODelivery,
                                          Remarks = s.Remarks,
                                          WORemarks = s.WORemarks,
                                          Note = s.Note,
                                          PartialShip = s.PartialShip,
                                          TransShipment = s.TransShipment,
                                          CreatedBy = s.CreatedBy,
                                          CreatedOn = s.CreatedOn,
                                          EditedBy = s.EditedBy,
                                          EditedOn = s.EditedOn,
                                          IsActive = s.IsActive
                                      }).FirstOrDefault();

                        if (result != null)
                        {
                            foreach (var item in _lstOrderitem)
                            {
                                result._objOrderItem.Add(item);
                            }
                        }

                        return result;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }


            return new Invoice() { };
        }

        public List<InvoiceMasterList> GetInvoiceByPartyNo(Invoice_RQ invoice_RQ)
        {
            if (invoice_RQ != null)
            {
                try
                {
                    using (LocalEntity _context = new LocalEntity())
                    {
                        var search = (from x in _context.tblInvoices select x).AsQueryable();
                        if (!string.IsNullOrWhiteSpace(invoice_RQ.PartyNo))
                        {
                            search = (from s in search
                                      where s.PartyNo == invoice_RQ.PartyNo
                                      select s).AsQueryable();
                        }

                        var result = (from x in search
                                      join p in _context.tblPartyMasters
                                      on x.PartyNo equals p.PartyCode
                                      select new InvoiceMasterList
                                      {
                                          InvoiceId = x.InvoiceId,
                                          InvoiceNo = x.InvoiceNo,
                                          PartyName = p.PartyName,
                                          InvoiceDate = x.InvoiceDate,
                                          InvoiceGrandAmt = x.InvoiceGrandAmt,
                                          Remarks = x.Remarks
                                      }).ToList();

                        return result;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return new List<InvoiceMasterList>() { };
        }
        public List<Invoice_RS> GetInvoice(Invoice_RQ _objInvoice)
        {
            List<Invoice_RS> _lstInvoice = new List<Invoice_RS>();
            try
            {
                using (LocalEntity _context = new LocalEntity())
                {
                    var search = _context.tblInvoices.AsQueryable();
                    if (!string.IsNullOrWhiteSpace(_objInvoice.InvoiceNo))
                    {
                        search = (from x in search
                                  where x.InvoiceNo == _objInvoice.InvoiceNo
                                  select x).AsQueryable();
                    }
                    if (_objInvoice.InvoiceDate != null)
                    {
                        search = (from x in search
                                  where x.InvoiceDate.Date == _objInvoice.InvoiceDate.Value
                                  select x).AsQueryable();
                    }
                    if (!string.IsNullOrWhiteSpace(_objInvoice.PartyNo))
                    {
                        search = (from x in search
                                  where x.PartyNo == _objInvoice.PartyNo
                                  select x).AsQueryable();
                    }
                    int total = search.Count();
                    int skip = (_objInvoice.PageNo * (_objInvoice.PageSize ?? 5));
                    _lstInvoice = (from s in search
                                   join p in _context.tblPartyMasters on s.PartyNo equals (p.PartyCode)
                                   select new Invoice_RS()
                                   {
                                       InvoiceId = s.InvoiceId,
                                       InvoiceNo = s.InvoiceNo,
                                       InvoiceGrandAmt = s.InvoiceGrandAmt,
                                       InvoiceGrandQty = Convert.ToString(s.InvoiceGrandQty),
                                       InvoiceDate = s.InvoiceDate,
                                       PartyName = p.PartyCode,
                                       InvoiceCurrency = s.InvoiceCurrency
                                   }).OrderBy(x => x.PartyName).Skip(skip).ToList();


                }
            }
            catch (Exception)
            {

                throw;
            }
            return _lstInvoice;
        }
        public Invoice CreateInvoice(Invoice _objCreateInvoice)
        {
            try
            {
                if (_objCreateInvoice != null)
                {
                    //Check Duplicate 

                    using (LocalEntity _context = new LocalEntity())
                    {
                        var invoice = _context.tblInvoices.OrderByDescending(x => x.InvoiceId).FirstOrDefault();
                        int intMaxId = 1;
                        int intInvoiceId = 1;
                        if (invoice != null)
                        {
                            intMaxId = invoice.InvoiceId + 1;
                            intInvoiceId = intInvoiceId + 1;
                        }
                        string strInvoiceNo = "SSB-" + intMaxId;

                        _context.tblInvoices.Add(new tblInvoice
                        {
                            InvoiceId = intInvoiceId,
                            InvoiceNo = strInvoiceNo,
                            PartyNo = _objCreateInvoice.PartyNo,
                            BankId = _objCreateInvoice.BankId,
                            Unit = _objCreateInvoice.Unit,
                            InvoiceDate = _objCreateInvoice.InvoiceDate,
                            InvoiceCurrency = _objCreateInvoice.InvoiceCurrency,
                            InvoiceGrandQty = Convert.ToDecimal(_objCreateInvoice.InvoiceGrandQty),
                            InvoiceGrandAmt = _objCreateInvoice.InvoiceGrandAmt,
                            Remark = _objCreateInvoice.Remark,
                            DeliveryTerms = _objCreateInvoice.DeliveryTerms,
                            DeliveryType = _objCreateInvoice.DeliveryType,
                            Port = _objCreateInvoice.Port,
                            PaymentTerms = _objCreateInvoice.PaymentTerms,
                            DeliveryPeriod = _objCreateInvoice.DeliveryPeriod,
                            WODelivery = _objCreateInvoice.WODelivery,
                            Remarks = _objCreateInvoice.Remarks,
                            WORemarks = _objCreateInvoice.WORemarks,
                            Note = _objCreateInvoice.Note,
                            PartialShip = _objCreateInvoice.PartialShip,
                            TransShipment = _objCreateInvoice.TransShipment,
                            CreatedBy = _objCreateInvoice.CreatedBy,
                            CreatedOn = _objCreateInvoice.CreatedOn,
                            EditedBy = _objCreateInvoice.EditedBy,
                            EditedOn = _objCreateInvoice.EditedOn,
                            IsActive = _objCreateInvoice.IsActive,
                        });
                        if (_context.SaveChanges() == 1)
                        {
                            //Create Item details
                            //var InvoiceItem = _context.tbl_InvoiceItemDetails.OrderByDescending(x => x.InvoiceItemID).FirstOrDefault();
                            //int intInvoiceItemID = 1;
                            //if (InvoiceItem != null)
                            Int32 intInvoiceItemID = GetItemDetailsMax();

                            //if (InvoiceItem != null)
                            //{
                            List<InvoiceItemDetails> _lstItems = new List<InvoiceItemDetails>();
                            int itemCount = 0;
                            foreach (var item in _objCreateInvoice._objOrderItem)
                            {
                                int intlocalInvoiceItemID = intInvoiceItemID + itemCount;
                                _context.tbl_InvoiceItemDetails.Add(new tbl_InvoiceItemDetails
                                {
                                    InvoiceItemID = intlocalInvoiceItemID,
                                    InvoiceNo = strInvoiceNo,
                                    Amount = item.Amount,
                                    ArtDesc = item.ArtDesc,
                                    ArtNo = item.ArtNo,
                                    Quantity = item.Quantity,
                                    Rate = item.Rate,
                                    RefileInk = item.RefileInk,
                                    WorkOrderDesc = item.WorkOrderDesc
                                });
                                itemCount++;
                            }
                            //}
                            _context.SaveChanges();
                            _objCreateInvoice.Code = Models.MessageCode.Success;
                            _objCreateInvoice.MessageText = strInvoiceNo + " has been created successfully.";
                            _objCreateInvoice.InvoiceNo = strInvoiceNo;
                        }
                        else
                        {
                            _objCreateInvoice.Code = Models.MessageCode.Error;
                            _objCreateInvoice.MessageText = "Not Created. Pleases contact administor !!";
                        }
                    }
                }
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _objCreateInvoice;
        }
        public Invoice UpdateInvoice(Invoice _objUpdateInvoice)
        {
            try
            {
                if (_objUpdateInvoice != null)
                {

                    using (LocalEntity _context = new LocalEntity())
                    {
                        var _Invoice = (from x in _context.tblInvoices
                                        where x.InvoiceNo == _objUpdateInvoice.InvoiceNo
                                        select x).FirstOrDefault();

                        if (_Invoice != null)
                        {
                            _Invoice.PartyNo = string.IsNullOrWhiteSpace(_objUpdateInvoice.PartyNo) ? _Invoice.PartyNo : Convert.ToString(_objUpdateInvoice.PartyNo);
                            _Invoice.BankId = string.IsNullOrWhiteSpace(_objUpdateInvoice.BankId) ? _Invoice.BankId : Convert.ToString(_objUpdateInvoice.BankId);
                            _Invoice.Unit = string.IsNullOrWhiteSpace(_objUpdateInvoice.Unit) ? _Invoice.Unit : Convert.ToString(_objUpdateInvoice.Unit);
                            _Invoice.InvoiceDate = string.IsNullOrWhiteSpace(Convert.ToString(_objUpdateInvoice.InvoiceDate)) ? _Invoice.InvoiceDate : Convert.ToDateTime(_objUpdateInvoice.InvoiceDate);
                            _Invoice.InvoiceCurrency = string.IsNullOrWhiteSpace(_objUpdateInvoice.InvoiceCurrency) ? _Invoice.InvoiceCurrency : Convert.ToString(_objUpdateInvoice.InvoiceCurrency);
                            _Invoice.InvoiceGrandQty = Convert.ToDecimal(_objUpdateInvoice.InvoiceGrandQty);
                            _Invoice.InvoiceGrandAmt = Convert.ToDecimal(_objUpdateInvoice.InvoiceGrandAmt);
                            _Invoice.Remark = string.IsNullOrWhiteSpace(_objUpdateInvoice.Remark) ? _Invoice.Remark : Convert.ToString(_objUpdateInvoice.Remark);
                            _Invoice.DeliveryTerms = string.IsNullOrWhiteSpace(_objUpdateInvoice.DeliveryTerms) ? _Invoice.DeliveryTerms : Convert.ToString(_objUpdateInvoice.DeliveryTerms);
                            _Invoice.DeliveryType = string.IsNullOrWhiteSpace(_objUpdateInvoice.DeliveryType) ? _Invoice.DeliveryType : Convert.ToString(_objUpdateInvoice.DeliveryType);
                            _Invoice.Port = string.IsNullOrWhiteSpace(_objUpdateInvoice.Port) ? _Invoice.Port : Convert.ToString(_objUpdateInvoice.Port);
                            _Invoice.PaymentTerms = string.IsNullOrWhiteSpace(_objUpdateInvoice.PaymentTerms) ? _Invoice.PaymentTerms : Convert.ToString(_objUpdateInvoice.PaymentTerms);
                            _Invoice.DeliveryPeriod = string.IsNullOrWhiteSpace(_objUpdateInvoice.DeliveryPeriod) ? _Invoice.DeliveryPeriod : Convert.ToString(_objUpdateInvoice.DeliveryPeriod);
                            _Invoice.WODelivery = string.IsNullOrWhiteSpace(_objUpdateInvoice.WODelivery) ? _Invoice.WODelivery : Convert.ToString(_objUpdateInvoice.WODelivery);
                            _Invoice.Remarks = string.IsNullOrWhiteSpace(_objUpdateInvoice.Remarks) ? _Invoice.Remarks : Convert.ToString(_objUpdateInvoice.Remarks);
                            _Invoice.WORemarks = string.IsNullOrWhiteSpace(_objUpdateInvoice.WORemarks) ? _Invoice.WORemarks : Convert.ToString(_objUpdateInvoice.WORemarks);
                            _Invoice.Note = string.IsNullOrWhiteSpace(_objUpdateInvoice.Note) ? _Invoice.Note : Convert.ToString(_objUpdateInvoice.Note);
                            _Invoice.PartialShip = string.IsNullOrWhiteSpace(_objUpdateInvoice.PartialShip) ? _Invoice.PartialShip : Convert.ToString(_objUpdateInvoice.PartialShip);
                            _Invoice.TransShipment = string.IsNullOrWhiteSpace(_objUpdateInvoice.TransShipment) ? _Invoice.TransShipment : Convert.ToString(_objUpdateInvoice.TransShipment);
                            //_Invoice.EditedBy = string.IsNullOrWhiteSpace(_objUpdateInvoice.PartyNo) ? _Invoice.PartyNo : Convert.ToString(_objUpdateInvoice.PartyNo);
                            //  _Invoice.EditedOn = string.IsNullOrWhiteSpace(_objUpdateInvoice.PartyNo) ? _Invoice.PartyNo : Convert.ToString(_objUpdateInvoice.PartyNo);
                            _Invoice.IsActive = string.IsNullOrWhiteSpace(_objUpdateInvoice.PartyNo) ? _Invoice.IsActive : Convert.ToBoolean(_objUpdateInvoice.IsActive);
                            if (_context.SaveChanges() >= 0)
                            {
                                if (_objUpdateInvoice._objOrderItem.Count() > 0)
                                {
                                    //Remove all item from the item details table before update new items in order
                                    var removedlist = _context.tbl_InvoiceItemDetails.Where(x => x.InvoiceNo == _objUpdateInvoice.InvoiceNo).ToList();
                                    foreach (var item in removedlist)
                                    {
                                        _context.tbl_InvoiceItemDetails.Remove(item);
                                    }
                                    _context.SaveChanges();

                                    //Now adding new row in tables
                                    Int32 intInvoiceItemID = GetItemDetailsMax();
                                    List<InvoiceItemDetails> _lstItems = new List<InvoiceItemDetails>();
                                    int itemCount = 0;
                                    foreach (var item in _objUpdateInvoice._objOrderItem)
                                    {
                                        int intlocalInvoiceItemID = intInvoiceItemID + itemCount;
                                        _context.tbl_InvoiceItemDetails.Add(new tbl_InvoiceItemDetails
                                        {
                                            InvoiceItemID = intlocalInvoiceItemID,
                                            InvoiceNo = _objUpdateInvoice.InvoiceNo,
                                            Amount = item.Amount,
                                            ArtDesc = item.ArtDesc,
                                            ArtNo = item.ArtNo,
                                            Quantity = item.Quantity,
                                            Rate = item.Rate,
                                            RefileInk = item.RefileInk,
                                            WorkOrderDesc = item.WorkOrderDesc
                                        });
                                        itemCount++;
                                    }
                                    _context.SaveChanges();
                                    _objUpdateInvoice.Code = Models.MessageCode.Success;
                                    _objUpdateInvoice.MessageText = _objUpdateInvoice.InvoiceNo + " has been update successfully.";
                                    _objUpdateInvoice.InvoiceNo = _objUpdateInvoice.InvoiceNo;
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
            return _objUpdateInvoice;
        }

        public Int32 GetItemDetailsMax()
        {
            Int32 intInvoiceItemID = 1;
            using (LocalEntity _context = new LocalEntity())
            {
                var InvoiceItem = _context.tbl_InvoiceItemDetails.OrderByDescending(x => x.InvoiceItemID).FirstOrDefault();
                if (InvoiceItem != null)
                    intInvoiceItemID = InvoiceItem.InvoiceItemID + 1;
            }
            return intInvoiceItemID;
        }
    }

}
