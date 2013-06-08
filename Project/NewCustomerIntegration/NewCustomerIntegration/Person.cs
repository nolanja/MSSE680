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
    
    public partial class Person
    {
        public Person()
        {
            this.CredentialRoles = new HashSet<CredentialRole>();
            this.Profiles = new HashSet<Profile>();
        }
    
        public long UserId { get; set; }
        public long OrganizationId { get; set; }
        public long UserTypeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string UnitName { get; set; }
        public string UnitNumber { get; set; }
        public string Department { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual Credential Credential { get; set; }
        public virtual ICollection<CredentialRole> CredentialRoles { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual OrganizationAdministrator OrganizationAdministrator { get; set; }
        public virtual ICollection<Profile> Profiles { get; set; }
    }
}
