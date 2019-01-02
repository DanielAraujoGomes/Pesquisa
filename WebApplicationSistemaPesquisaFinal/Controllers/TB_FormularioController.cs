using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationSistemaPesquisaFinal.Models;

namespace WebApplicationSistemaPesquisaFinal.Controllers
{
    public class TB_FormularioController : Controller
    {
        private DEV_PESQUISA_SATISFACAOEntities db = new DEV_PESQUISA_SATISFACAOEntities();

        // GET: TB_Formulario
        public ActionResult Index(int Id_pesquisa,int Id_Participante)
        {
            var questoes = db.TB_Questoes.Where(x => x.PesquisaId == Id_pesquisa).ToList();

            var listaDeQuestoes = new List<Formulario>();

            foreach (var item in questoes)
            {
                listaDeQuestoes.Add(new Formulario() {

                    PesquisaId = item.PesquisaId,
                    Titulo = item.TB_Pesquisa.Titulo,
                    Descricao = item.TB_Pesquisa.Descricao,
                    QuestaoId = item.QuestaoId,
                    Questao = item.Questao,
                    TipoRespostaId = item.TipoRespostaId,
                    //AlternativaId = item.AlternativaId,
                    Alternativas = db.TB_Alternativas.Where(x => x.QuestaoId == item.QuestaoId).ToList(),
                    //Alternativa = item.Alternativa
                });
            }

            return View(listaDeQuestoes);
        }


    }
}