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
    
    public partial class Audio
    {
        public long AudioId { get; set; }
        public long AccountId { get; set; }
        public string AudioName { get; set; }
        public string AudioContactNo1 { get; set; }
        public string AudioContactNo2 { get; set; }
        public string AudioAdress { get; set; }
        public string AudioEmail { get; set; }
        public string Remarks { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string Status { get; set; }
    }
}
