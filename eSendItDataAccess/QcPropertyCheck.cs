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
    
    public partial class QcPropertyCheck
    {
        public int QcCheckId { get; set; }
        public Nullable<int> PropertyId { get; set; }
        public string QcType { get; set; }
        public Nullable<int> MaxValue { get; set; }
        public Nullable<int> MinValue { get; set; }
        public string FixedValue { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
