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
    
    public partial class TB_Pesquisa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Pesquisa()
        {
            this.TB_Participantes = new HashSet<TB_Participantes>();
            this.TB_Questoes = new HashSet<TB_Questoes>();
        }
    
        public int PesquisaId { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Participantes> TB_Participantes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Questoes> TB_Questoes { get; set; }
    }
}
