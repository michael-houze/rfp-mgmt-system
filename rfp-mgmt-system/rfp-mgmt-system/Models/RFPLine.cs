// Class File: RFPLine.cs
// Purpose: This class represents a model for a RFPLine in the RFP Management System.  A RFPLine is
//          a request for a single product.  Multiple RFPLines make up a Bid.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rfp_mgmt_system.Models
{
    public class RFPLine
    {
        // Property: RFPLineID
        // Description: This property uniquely identifies the RFPLine in the system.
        public int RFPLineID { get; set; }

        // Property: TimeUnit
        // Description: This property describes that unit in which time is measured for the RFP.
        public string TimeUnit { get; set; }

        // Property: TimeValue
        // Description: This property describes that value in which time is measured for the RFP.
        public int TimeValue { get; set; }

        // Property: Product
        // Description: This property represents the Product that makes up this RFPLine.
        public Product Product { get; set; }

        // Property: RFP
        // Description: This property represents the RFP that makes that this RFPLine is on.
        public RFP RFP { get; set; }
    }
}