//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace rfp_mgmt_system.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    
    public partial class VENDOR
    {
        public VENDOR()
        {
            this.Contracts = new HashSet<Contract>();
            this.RFI_INVITE = new HashSet<RFI_INVITE>();
            this.RFP_INVITE = new HashSet<RFP_INVITE>();
            this.ITEMs = new HashSet<ITEM>();
        }
    
        public int Vendor_ID { get; set; }
        [DisplayName("Representative First Name")]
        public string VendorFirstName { get; set; }
        [DisplayName("Representative First Name")]
        public string VendorLastName { get; set; }
        [DisplayName("Phone Number")]
        public string VendorPhone { get; set; }
        [DisplayName("Email Address")]
        public string VendorEmail { get; set; }
        [DisplayName("Company Name")]
        public string CompanyName { get; set; }
        [DisplayName("Street Address")]
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [DisplayName("Zip Code")]
        public Nullable<int> Zip { get; set; }
        public string Sanctioned { get; set; }
    
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<RFI_INVITE> RFI_INVITE { get; set; }
        public virtual ICollection<RFP_INVITE> RFP_INVITE { get; set; }
        public virtual VENDOR_LOGIN VENDOR_LOGIN { get; set; }
        public virtual ICollection<ITEM> ITEMs { get; set; }
    }
}
