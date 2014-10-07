using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace rfp_mgmt_system.Models.ViewModels
{
    public class VendorReg
    {
        public int Vendor_ID { get; set; }
        [DisplayName("First Name")]
        public string VendorFirstName { get; set; }
        [DisplayName("Last Name")]
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
        public virtual VENDOR_LOGIN VENDOR_LOGIN { get; set; }
        public virtual ICollection<ITEM> Items { get; set; }
    }
}