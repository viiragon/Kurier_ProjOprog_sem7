//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppKurierska
{
    using System;
    using System.Collections.Generic;
    
    public partial class oddzialy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public oddzialy()
        {
            this.przeplywy = new HashSet<przeplywy>();
            this.regiony = new HashSet<regiony>();
        }
    
        public int oddzial_id { get; set; }
        public string nazwa { get; set; }
        public string ulica { get; set; }
        public string kod_pocztowy { get; set; }
        public string miasto { get; set; }
        public string telefon { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<przeplywy> przeplywy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<regiony> regiony { get; set; }
    }
}