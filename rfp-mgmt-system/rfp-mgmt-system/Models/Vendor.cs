// Class File: Vendor.cs
// Purpose: This class represents a model for a Vendor in the RFP Management System.  A Vendor is the supplier
//          of products requested using the RFP Management System.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rfp_mgmt_system.Models
{
    public class Vendor
    {
        // Property: VendorID
        // Description: This property uniquely identifies the Vendor in the system.
        public int VendorID { get; set; }

        // Property: BillingCity
        // Description: This property denotes the city in which the Vendor bills from.
        public string BillingCity { get; set; }

        // Property: BillingState
        // Description: This property denotes the state in which the Vendor bills from.
        public string BillingState { get; set; }

        // Property: BillingStreet
        // Description: This property denotes the street in which the Vendor bills from.
        public string BillingStreet { get; set; }

        // Property: BillingZip
        // Description: This property denotes the zip code in which the Vendor bills from.
        public string BillingZip { get; set; }

        // Property: City
        // Description: This property denotes the city in which the Vendor ships from.
        public string City { get; set; }

        // Property: Email
        // Description: This property denotes the email address for contacting the Vendor.
        public string Email { get; set; }

        // Property: Market
        // Description: This property denotes the market in which the Vendor focuses their product lines.
        public string Market { get; set; }

        // Property: Name
        // Description: This property denotes the name of the contact for the Vendor.
        public string Name { get; set; }

        // Property: Password
        // Description: This property denotes the password in which the Vendor representative will use to
        //              lof into the system.
        public string Password { get; set; }

        // Property: Email
        // Description: This property denotes the phone number for contacting the Vendor.
        public string PhoneNumber { get; set; }

        // Property: Reference
        // Description: This property denotes the reference used by the Vendor during registration.
        public string Reference { get; set; }

        // Property: State
        // Description: This property denotes the state in which the Vendor ships from.
        public string State { get; set; }

        // Property: Status
        // Description: This property represents the status of the Vendor in using the system.
        public string Status { get; set; }

        // Property: Street
        // Description: This property denotes the street in which the Vendor ships from.
        public string Street { get; set; }

        // Property: Username
        // Description: This property denotes the username in which the Vendor representative will use to
        //              lof into the system.
        public string Username { get; set; }

        // Property: ZipCode
        // Description: This property denotes the zip code in which the Vendor ships from.
        public string ZipCode { get; set; }

        // Property: Employee
        // Description: This property denotes the Employee that approved the Vendor.
        public Employee Employee { get; set; }

        // Property: Supplies
        // Description: This property denotes the list of Supplies provided by the Vendor.
        public List<Supply> Supplies { get; set; }

        // Property: RFPs
        // Description: This property denotes the list of RFPs the Vendor has been approved to create Bids for.
        public List<RFP> RFPs { get; set; }

        // Property: Bids
        // Description: This property denotes the list of Bids the Vendor has placed on RFPs.
        public List<Bid> Bids { get; set; }

        // Property: Contracts
        // Description: This property denotes the list of Contracts the Vendor has been associated with in the system.
        public List<RFP> Contracts { get; set; }
    }
}