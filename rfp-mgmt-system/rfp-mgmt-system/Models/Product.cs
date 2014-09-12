// Class File: Product.cs
// Purpose: This class represents a model for a Product in the RFP Management System.  A Product is
//          provided by a Vendor and makes up the basis of the RFP system.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rfp_mgmt_system.Models
{
    public class Product
    {
        // Property: Product
        // Description: This property uniquely identifies the Product in the system.
        public int ProductID { get; set; }

        // Property: Description
        // Description: This property details the specifics of a product, including specifics.
        public string Description { get; set; }

        // Property: Type
        // Description: This property details the category of the Product.
        public string Type { get; set; }

        // Property: PackageUnit
        // Description: This property details how many units of each Product are in a shipping unit.
        public int PackageUnit { get; set; }
    }
}