//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VENTA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VENTA()
        {
            this.DETALLEVENTA = new HashSet<DETALLEVENTA>();
        }
    
        public int IIDVENTA { get; set; }
        public Nullable<int> IIDCLIENTE { get; set; }
        public Nullable<decimal> TOTAL { get; set; }
        public Nullable<System.DateTime> FECHAVENTA { get; set; }
        public Nullable<int> BHABILITADO { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLEVENTA> DETALLEVENTA { get; set; }
    }
}
