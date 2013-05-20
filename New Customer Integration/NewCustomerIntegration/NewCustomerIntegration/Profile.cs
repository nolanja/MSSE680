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
    
    public partial class Profile
    {
        public long ProfileId { get; set; }
        public long UserId { get; set; }
        public long UserTypeId { get; set; }
        public long NavigationId { get; set; }
        public int GridPageSize { get; set; }
        public string ControlSettings { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual Navigation Navigation { get; set; }
        public virtual Person Person { get; set; }
        public virtual UserType UserType { get; set; }
    }
}
