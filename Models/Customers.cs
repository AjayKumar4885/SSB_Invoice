using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Customers :Message
    {
        public int Id { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string ContactPerson { get; set; }
        public string MobileNo { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedOn { get; set; }
        public bool IsActive { get; set; }
        

    }

    public class RS_Customers 
    {
        public int Id { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string ContactPerson { get; set; }
        public string MobileNo { get; set; }
        public bool IsActive { get; set; }
        public int? PageNo { get; set; }
        public int? PageSize { get; set; }
        public int? TotalPage { get; set; }

    }

    public class RQ_Customer
    {
        public int? CustId { get; set; }
        public string CustomerName { get; set; }
        public int? PageNo { get; set; }
        public int? PageSize { get; set; }

    }
}
