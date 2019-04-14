using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Invoice : Message
    {
        public int InvoiceId { get; set; }
        public string InvoiceNo { get; set; }
        public string PartyNo { get; set; }
        public string BankId { get; set; }
        public string Unit { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public string InvoiceCurrency { get; set; }
        public decimal InvoiceGrandQty { get; set; }
        public Nullable<decimal> InvoiceGrandAmt { get; set; }
        public string Remark { get; set; }
        public string DeliveryTerms { get; set; }
        public string DeliveryType { get; set; }
        public string Port { get; set; }
        public string PaymentTerms { get; set; }
        public string DeliveryPeriod { get; set; }
        public string WODelivery { get; set; }
        public string Remarks { get; set; }
        public string WORemarks { get; set; }
        public string Note { get; set; }
        public string PartialShip { get; set; }
        public string TransShipment { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string EditedBy { get; set; }
        public Nullable<System.DateTime> EditedOn { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public List<InvoiceItemDetails> _objOrderItem = new List<InvoiceItemDetails>();
    }

    public class Invoice_RQ
    {
        public int InvoiceId { get; set; }
        public string InvoiceNo { get; set; }
        public System.DateTime? InvoiceDate { get; set; }
        public string PartyNo { get; set; }
        public int PageNo { get; set; }
        public int? PageSize { get; set; }
    }
    public class Invoice_RS
    {
        public int InvoiceId { get; set; }
        public string InvoiceNo { get; set; }
        public System.DateTime? InvoiceDate { get; set; }
        public string InvoiceCurrency { get; set; }
        public string InvoiceGrandQty { get; set; }
        public Nullable<decimal> InvoiceGrandAmt { get; set; }
        public string PartyName { get; set; }

    }

    public class InvoiceMasterList
    {
        public int InvoiceId { get; set; }
        public string PartyName { get; set; }
        public string InvoiceNo { get; set; }
        public System.DateTime? InvoiceDate { get; set; }
        public Nullable<decimal> InvoiceGrandAmt { get; set; }
        public string Remarks { get; set; }
    }
}
