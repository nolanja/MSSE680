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
    
    public partial class AddressType
    {
        public AddressType()
        {
            this.Addresses = new HashSet<Address>();
        }
    
        public long AddressTypeId { get; set; }
        public string AddressTypeName { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
