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
    
    public partial class KonaklayanDetay
    {
        public int KonaklayanDetayID { get; set; }
        public int RezervasyonDetayID { get; set; }
        public int KonaklayanID { get; set; }
    
        public virtual Konaklayan Konaklayan { get; set; }
        public virtual RezervasyonDetay RezervasyonDetay { get; set; }
    }
}
