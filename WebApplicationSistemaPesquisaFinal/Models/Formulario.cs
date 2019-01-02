using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationSistemaPesquisaFinal.Models
{

    public class Formulario
    {
        public int PesquisaId { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int QuestaoId { get; set; }
        public string Questao { get; set; }
        public int TipoRespostaId { get; set; }

        public virtual ICollection<TB_Alternativas> Alternativas { get; set; }

        public int AlternativaId { get; set; }

        public string Alternativa { get; set; }
        
        public int ParticipanteId { get; set; }

        public virtual TB_TipoResposta TipoResposta { get; set; }
        
        public virtual TB_Participantes Participantes { get; set; }


    }
}