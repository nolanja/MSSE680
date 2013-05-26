using System;
using System.Collections.Generic;

namespace NewCustomerIntegration.Models
{
    public partial class Site
    {
        public long SiteId { get; set; }
        public long OrganizationId { get; set; }
        public long SiteTypeId { get; set; }
        public string SiteName { get; set; }
        public string SiteCode { get; set; }
        public long TimeZoneId { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public string ModifiedBy { get; set; }
    }
}
