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
    
    public partial class DVDCopy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DVDCopy()
        {
            this.Loans = new HashSet<Loan>();
        }
    
        public int DCopyId { get; set; }
        public int DVDId { get; set; }
        public string Price { get; set; }
        public System.DateTime ReleasedDate { get; set; }
        public string Description { get; set; }
    
        public virtual DVDDetail DVDDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Loan> Loans { get; set; }
    }
}