// Class File: Contract.cs
// Purpose: This class represents a model for a contract in the RFP Management System.  A contract is
//          derived from an RFP bid that has been approved by an Employee.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rfp_mgmt_system.Models
{
    public class Contract {
        // Property: ContractID
        // Description: This property uniquely identifies the Contract in the system.
        public int ContractID { get; set; }

        // Property: Description
        // Description: This property details the specifics of the Contract, which includes any details that may
        //              not be included in the Bid that was used to create the Contract.
        public string Description { get; set; }

        // Property: StartDate
        // Description: This property identifies the starting date that the terms of the Contract will begin on.
        public DateTime StartDate { get; set; }

        // Property: EndDate
        // Description: This property identifies the ending date that the terms of the Contract will begin on. 
        public DateTime EndDate { get; set; }

        // Property: Price
        // Description: This property represents the total value of the items to be supplied by this Contract.
        public decimal Price { get; set; }

        // Property: Bid
        // Description: This property represents the Vendor Bid that the Contract derives from.
        public Bid Bid { get; set; }

        // Property: Employee
        // Description: This property represents the Employee that approved the Bid that is used in the creation
        //              of the Contract.
        public Employee Employee { get; set; }
    }
}