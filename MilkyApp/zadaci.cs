//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MilkyApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class zadaci
    {
        public int zadatak_ID { get; set; }
        public string opis { get; set; }
        public byte[] datum { get; set; }
        public System.DateTime datum_izvrsenja { get; set; }
        public int korisnik_ID { get; set; }
    
        public virtual korisnici korisnici { get; set; }
    }
}
