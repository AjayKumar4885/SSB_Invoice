//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_InvoiceItemDetails
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
}
