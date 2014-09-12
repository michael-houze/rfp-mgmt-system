// Class File: BidLine.cs
// Purpose: This class represents a model for a BidLine in the RFP Management System.  A BidLine is
//          a Bid for a single product.  Multiple BidLines make up a Bid.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rfp_mgmt_system.Models
{
    public class BidLine
    {
        // Property: BidLineID
        // Description: This property uniquely identifies the BidLine in the system.
        public int BidLineID { get; set; }

        // Property: TimeUnit
        // Description: This property describes that unit in which time is measured for the Bid.
        public string TimeUnit { get; set; }

        // Property: TimeValue
        // Description: This property describes that value in which time is measured for the Bid.
        public int TimeValue { get; set; }

        // Property: UnitPrice
        // Description: This property describes the price per unit the Vendor will charge for the
        //              Product on this BidLine.
        public decimal UnitPrice { get; set; }

        // Property: Bid
        // Description: This property describes the Bid on which the BidLine is located.
        public Bid Bid { get; set; }

        // Property: Product
        // Description: This property describes the Product on which the BidLine is based off of.
        public Product Product { get; set; }
    }
}