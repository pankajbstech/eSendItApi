//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eSendItDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Production
    {
        public long ProductionId { get; set; }
        public long AccountId { get; set; }
        public string ProductionName { get; set; }
        public string ProductionContactNo1 { get; set; }
        public string ProductionContactNo2 { get; set; }
        public string ProductionAddress { get; set; }
        public string ProductionEmail { get; set; }
        public string Remarks { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string Status { get; set; }
    }
}
