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
    
    public partial class przesylki
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public przesylki()
        {
            this.reklamacje = new HashSet<reklamacje>();
        }
    
        public int przesylka_id { get; set; }
        public string numer { get; set; }
        public double koszt { get; set; }
        public string ubezpieczenie { get; set; }
        public string wymiary { get; set; }
        public double waga { get; set; }
        public string typ { get; set; }
    
        public virtual przeplywy przeplywy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reklamacje> reklamacje { get; set; }
        public virtual zamowienia zamowienia { get; set; }
    }
}