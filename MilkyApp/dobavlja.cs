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
    
    public partial class dobavlja
    {
        public int dobavljac_ID { get; set; }
        public int sirovina_ID { get; set; }
        public System.DateTime datum_dostave { get; set; }
        public int kolicina { get; set; }
    
        public virtual dobavljaci dobavljaci { get; set; }
        public virtual sirovine sirovine { get; set; }
    }
}
