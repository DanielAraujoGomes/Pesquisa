using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplicationSistemaPesquisaFinal.Models;

namespace WebApplicationSistemaPesquisaFinal.Controllers
{
    public class TB_QuestoesController : Controller
    {
        private DEV_PESQUISA_SATISFACAOEntities db = new DEV_PESQUISA_SATISFACAOEntities();

        // GET: TB_Questoes
        public ActionResult Index()
        {
            var tB_Questoes = db.TB_Questoes.Include(t => t.TB_Pesquisa).Include(t => t.TB_TipoResposta);
            return View(tB_Questoes.ToList());
        }

        // GET: TB_Questoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_Questoes tB_Questoes = db.TB_Questoes.Find(id);
            if (tB_Questoes == null)
            {
                return HttpNotFound();
            }
            return View(tB_Questoes);
        }

        // GET: TB_Questoes/Create
        public ActionResult Create()
        {
            ViewBag.PesquisaId = new SelectList(db.TB_Pesquisa, "PesquisaId", "Titulo");
            ViewBag.TipoRespostaId = new SelectList(db.TB_TipoResposta, "TipoRespostaId", "TipoResposta");
            return View();
        }

        // POST: TB_Questoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "QuestaoId,PesquisaId,Questao,TipoRespostaId")] TB_Questoes tB_Questoes)
        {
            if (ModelState.IsValid)
            {
                db.TB_Questoes.Add(tB_Questoes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PesquisaId = new SelectList(db.TB_Pesquisa, "PesquisaId", "Titulo", tB_Questoes.PesquisaId);
            ViewBag.TipoRespostaId = new SelectList(db.TB_TipoResposta, "TipoRespostaId", "TipoResposta", tB_Questoes.TipoRespostaId);
            return View(tB_Questoes);
        }

        // GET: TB_Questoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_Questoes tB_Questoes = db.TB_Questoes.Find(id);
            if (tB_Questoes == null)
            {
                return HttpNotFound();
            }
            ViewBag.PesquisaId = new SelectList(db.TB_Pesquisa, "PesquisaId", "Titulo", tB_Questoes.PesquisaId);
            ViewBag.TipoRespostaId = new SelectList(db.TB_TipoResposta, "TipoRespostaId", "TipoResposta", tB_Questoes.TipoRespostaId);
            return View(tB_Questoes);
        }

        // POST: TB_Questoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "QuestaoId,PesquisaId,Questao,TipoRespostaId")] TB_Questoes tB_Questoes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tB_Questoes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PesquisaId = new SelectList(db.TB_Pesquisa, "PesquisaId", "Titulo", tB_Questoes.PesquisaId);
            ViewBag.TipoRespostaId = new SelectList(db.TB_TipoResposta, "TipoRespostaId", "TipoResposta", tB_Questoes.TipoRespostaId);
            return View(tB_Questoes);
        }

        // GET: TB_Questoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_Questoes tB_Questoes = db.TB_Questoes.Find(id);
            if (tB_Questoes == null)
            {
                return HttpNotFound();
            }
            return View(tB_Questoes);
        }

        // POST: TB_Questoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_Questoes tB_Questoes = db.TB_Questoes.Find(id);
            db.TB_Questoes.Remove(tB_Questoes);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
