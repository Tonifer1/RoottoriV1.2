//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RoottoriV1._2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MalliE6RTyokalut
    {
        public int TyokaluPaikka { get; set; }
        public int TyokaluID { get; set; }
        public string Kesto { get; set; }
        public Nullable<System.DateTime> Paivitys { get; set; }
    
        public virtual KirjastoTyokalut KirjastoTyokalut { get; set; }

    }
}
