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
    
    public partial class Client
    {
        public long ClientId { get; set; }
        public long AccountId { get; set; }
        public Nullable<long> AdvertiserGroupId { get; set; }
        public string ClientName { get; set; }
        public string ClientContactNo1 { get; set; }
        public string ClientContactNo2 { get; set; }
        public string ClientAddress { get; set; }
        public string ClientEmail { get; set; }
        public string Remarks { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string Status { get; set; }
    }
}
