using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_InvoiceItem : Message
    {
        public List<InvoiceItemDetails> GetInvoiceItemByInvoiceNo(InvoiceItem_RQ _obj)
        {
            if (!string.IsNullOrWhiteSpace(_obj.InvoiceNo))
            {
                using (LocalEntity _context = new LocalEntity())
                {
                    //var search = _context.tblCustomers.();
                    var search = (from x in _context.tbl_InvoiceItemDetails
                                  where x.InvoiceNo.ToLower() == _obj.InvoiceNo.ToLower()
                                  select x).AsQueryable();
                    var result = (from x in search
                                  select new InvoiceItemDetails
                                  {
                                      Amount = x.Amount,
                                      ArtDesc = x.ArtDesc,
                                      ArtNo = x.ArtNo,
                                      InvoiceItemID = x.InvoiceItemID,
                                      InvoiceNo = x.InvoiceNo,
                                      Quantity = x.Quantity,
                                      Rate = x.Rate,
                                      RefileInk = x.RefileInk,
                                      WorkOrderDesc = x.WorkOrderDesc
                                  }).ToList();
                    return result;
                }

            }
            return new List<InvoiceItemDetails>() { };
        }
    }
}
