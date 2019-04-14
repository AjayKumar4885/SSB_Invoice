using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Article : Message
    {
        public int ArtId { get; set; }
        public string ArtNo { get; set; }
        public string Desc { get; set; }
        public string WorkOrderDesc { get; set; }
        public Nullable<double> Rate { get; set; }
        public string Unit { get; set; }
        public string ImageName { get; set; }
        public string ImagePath { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> EditedOn { get; set; }
        public string EditedBy { get; set; }
        public bool IsActive { get; set; }
    }

    public class ArticleRS
    {
        public int ArtId { get; set; }
        public string ArtNo { get; set; }
        public string Desc { get; set; }
    }
    public class ArticleWithDescRS
    {
        public int ArtId { get; set; }
        public string ArtNo { get; set; }
        public string ArtNoWithDesc { get; set; }
    }
    public class ArticleRQ
    {
        public int ArtId { get; set; }
        public string ArtNo { get; set; }
        public string Desc { get; set; }
    }
}
