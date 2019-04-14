using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class InvoiceOrderItems
    {
        public int invoiceOrderItemId { get; set; }
        public int ArtId { get; set; }
        public string ArtNo { get; set; }
        public string Desc { get; set; }
        public string WorkOrderDesc { get; set; }
        public List<RefillInk> RefillInk { get; set; } = new List<RefillInk>();
        public double Rate { get; set; }
        public double Qty { get; set; }
        public double Amount { get; set; }
        public int Sequence { get; set; }
        public int RefillInkId { get; set; }
    }
}
