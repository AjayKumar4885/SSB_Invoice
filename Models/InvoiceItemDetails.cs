using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class InvoiceItemDetails
    {
        public int InvoiceItemID { get; set; }
        public string InvoiceNo { get; set; }
        public string ArtNo { get; set; }
        public string ArtDesc { get; set; }
        public string WorkOrderDesc { get; set; }
        public string RefileInk { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public int? Quantity { get; set; }
        public Nullable<decimal> Amount { get; set; }
    }
    public class InvoiceItem_RQ
    {
        public string InvoiceNo { get; set; }
    }
}
