//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Triathlon
{
    using System;
    using System.Collections.Generic;
    
    public partial class TRIATHLON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRIATHLON()
        {
            this.INSCRIPTIONs = new HashSet<INSCRIPTION>();
        }
    
        public string numTriathlon { get; set; }
        public string lieu { get; set; }
        public string nom { get; set; }
        public Nullable<System.DateTime> dateTriathlon { get; set; }
        public string codeType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSCRIPTION> INSCRIPTIONs { get; set; }
        public virtual TYPE_TRIATHLON TYPE_TRIATHLON { get; set; }
    }
}