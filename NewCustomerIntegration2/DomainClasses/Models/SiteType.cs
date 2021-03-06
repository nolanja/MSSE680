using System;
using System.Collections.Generic;

namespace DomainLayer.Models
{
    public partial class SiteType
    {
        public long SiteTypeId { get; set; }
        public string SiteTypeName { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public string ModifiedBy { get; set; }
    }
}
