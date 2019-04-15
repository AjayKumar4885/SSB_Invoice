using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class RefillInk : Message
    {
        public int id { get; set; }
        public string RefillInkColor { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
    public class RefillInk_RQ
    {
        public int id { get; set; }
        public string RefillInkColor { get; set; }
    }
}
