//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationSistemaPesquisaFinal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_TipoResposta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_TipoResposta()
        {
            this.TB_Questoes = new HashSet<TB_Questoes>();
        }
    
        public int TipoRespostaId { get; set; }
        public string TipoResposta { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Questoes> TB_Questoes { get; set; }
    }
}