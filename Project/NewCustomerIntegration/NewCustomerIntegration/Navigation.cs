//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewCustomerIntegration
{
    using System;
    using System.Collections.Generic;
    
    public partial class Navigation
    {
        public Navigation()
        {
            this.Profiles = new HashSet<Profile>();
        }
    
        public long NavigationId { get; set; }
        public string NavigationName { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual ICollection<Profile> Profiles { get; set; }
    }
}
