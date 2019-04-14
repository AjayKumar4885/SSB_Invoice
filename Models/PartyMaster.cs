using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PartyMaster : Message
    {
        public int PartyId { get; set; }
        public string PartyCode { get; set; }
        public string PartyName { get; set; }
        public string ContactPerson { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Pager { get; set; }
        public string Email { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string EditedBy { get; set; }
        public Nullable<System.DateTime> EditedOn { get; set; }
        public bool IsActive { get; set; }
    }
    public class PartyMasterRS
    {
        public int PartyId { get; set; }
        public string PartyCode { get; set; }
        public string PartyName { get; set; }
    }

    public class PartyMasterRQ
    {
        public int PartyId { get; set; }
        public string PartyCode { get; set; }
        public string PartyName { get; set; }
    }
}
