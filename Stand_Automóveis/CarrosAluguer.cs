//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stand_Automoveis
{
    using System;
    using System.Collections.Generic;
    
    public partial class CarrosAluguer : Carros
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CarrosAluguer()
        {
            this.Aluguer = new HashSet<Alugueres>();
        }
    
        public string Estado { get; set; }
        public string Matricula { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alugueres> Aluguer { get; set; }
    }
}
