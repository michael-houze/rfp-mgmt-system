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
    
    public partial class RFP
    {
        public RFP()
        {
            this.RFP_INVITE = new HashSet<RFP_INVITE>();
        }
    
        public int RFP_ID { get; set; }
    
        public virtual ICollection<RFP_INVITE> RFP_INVITE { get; set; }
    }
}
