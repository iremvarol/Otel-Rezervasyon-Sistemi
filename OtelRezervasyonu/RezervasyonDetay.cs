//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OtelRezervasyonu
{
    using System;
    using System.Collections.Generic;
    
    public partial class RezervasyonDetay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RezervasyonDetay()
        {
            this.KonaklayanDetay = new HashSet<KonaklayanDetay>();
        }
    
        public int RezervasyonDetayID { get; set; }
        public Nullable<int> RezervasyonID { get; set; }
        public int OdaID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KonaklayanDetay> KonaklayanDetay { get; set; }
        public virtual Oda Oda { get; set; }
        public virtual Rezervasyon Rezervasyon { get; set; }
    }
}
