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
    
    public partial class Version
    {
        public long VersionId { get; set; }
        public long AccountId { get; set; }
        public long ProjectId { get; set; }
        public string KeyNumber { get; set; }
        public string Title { get; set; }
        public int FormatTypeId { get; set; }
        public System.TimeSpan Duration { get; set; }
        public int AudioTypeId { get; set; }
        public int LanguageTypeId { get; set; }
        public string FilePath { get; set; }
        public string QCStatus { get; set; }
        public string Remarks { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string Status { get; set; }
    }
}
