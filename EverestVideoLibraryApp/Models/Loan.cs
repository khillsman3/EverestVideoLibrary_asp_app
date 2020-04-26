//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EverestVideoLibraryApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Loan
    {
        public int LoanId { get; set; }
        public int MemberId { get; set; }
        public int DCopyId { get; set; }
        public System.DateTime IssuedDate { get; set; }
        public System.DateTime DueDate { get; set; }
        public Nullable<System.DateTime> ReturnedDate { get; set; }
        public string DueAmount { get; set; }
        public string FineAmount { get; set; }
    
        public virtual DVDCopy DVDCopy { get; set; }
        public virtual Member Member { get; set; }
    }
}