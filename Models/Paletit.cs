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
    using System.ComponentModel.DataAnnotations;
    //Lis�tty virheentarkistus@Toni
    public partial class Paletit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Paletit()
        {
            this.Roottorit = new HashSet<Roottorit>();
        }
    
        public int PalettiID { get; set; }

        [Required(ErrorMessage = "Paletti malli on pakollinen")]
        public string Paletti { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Roottorit> Roottorit { get; set; }
    }
}
