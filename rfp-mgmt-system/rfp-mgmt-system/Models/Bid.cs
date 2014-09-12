// Class File: Bid.cs
// Purpose: This class represents a model for a bid in the RFP Management System.  A bid is
//          created by a Vendor in response to an RFP.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rfp_mgmt_system.Models
{
    public class Bid {
        // Property: BidID
        // Description: This property uniquely identifies the Bid in the system.
        public int BidID { get; set; }

        // Property: TotalPrice
        // Description: This property represents the total price of all items included on this Bid.
        public decimal TotalPrice { get; set; }

        // Property: RFP
        // Description: This property represents the RFP in which the Bid was placed on.
        public RFP RFP { get; set; }

        // Property: Contract
        // Description: This property represents the Contract in which was derived from this Bid.
        public Contract Contract { get; set; }

        // Property: BidLines
        // Description: This property represents a list of BidLines that make up the Bid.
        public List<BidLine> BidLines { get; set; }

        // Property: Vendor
        // Description: This property represents the Vendor that placed the Bid.
        public Vendor Vendor { get; set; }
    }
}