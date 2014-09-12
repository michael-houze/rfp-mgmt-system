// Class File: Supply.cs
// Purpose: This class represents a model for a Supply in the RFP Management System.  A Supply is
//          a singular product available from a Vendor.  It acts as a bridge between the list of Vendors
//          and the list of Products.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rfp_mgmt_system.Models
{
    public class Supply
    {
        // Property: SupplyID
        // Description: This property uniquely identifies the Supply in the system.
        public int SupplyID { get; set; }

        // Property: Product
        // Description: This property describes the Product in which the Vendor can provide.
        public Product Product { get; set; }

        // Property: Vendor
        // Description: This property describes the Vendor in which the Supply is provided by.
        public Vendor Vendor { get; set; }
    }
}