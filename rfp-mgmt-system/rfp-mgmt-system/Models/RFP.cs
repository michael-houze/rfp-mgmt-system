// Class File: RFP.cs
// Purpose: This class represents a model for an RFP in the RFP Management System.  An RFP is
//          created by an Employee, which can be accessed by select Vendors.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rfp_mgmt_system.Models
{
    public class RFP{
        // Property: RFPID
        // Description: This property uniquely identifies the RFP in the system.
        public int RFPID { get; set; }

        // Property: Employee
        // Description: This property represents the Employee that created the RFP.
        public Employee Employee { get; set; }

        // Property: StartDate
        // Description: This property represents the date that bidding can begin on this RFP.
        public DateTime StartDate { get; set; }

        // Property: EndDate
        // Description: This property represents the date that bidding ends on this RFP.
        public DateTime EndDate { get; set; }

        // Property: Bids
        // Description: This property represents the list of Bids that have been created for this RFP.
        public List<Bid> Bids { get; set; }

        // Property: RFPLines
        // Description: This property represents the list of RFP lines that make up the RFP.
        public List<RFPLine> RFPLines { get; set; }

        // Property: Vendors
        // Description: This property is a list of the Vendors that are able to access this RFP.
        public List<Vendor> Vendors { get; set; }
    }
}