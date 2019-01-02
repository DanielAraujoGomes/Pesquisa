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
    public class TB_RespostasController : Controller
    {
        private DEV_PESQUISA_SATISFACAOEntities db = new DEV_PESQUISA_SATISFACAOEntities();

        // GET: TB_Respostas
        public ActionResult Index()
        {
            var tB_Respostas = db.TB_Respostas.Include(t => t.TB_Questoes);
            return View(tB_Respostas.ToList());
        }

        // GET: TB_Respostas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_Respostas tB_Respostas = db.TB_Respostas.Find(id);
            if (tB_Respostas == null)
            {
                return HttpNotFound();
            }
            return View(tB_Respostas);
        }

        // GET: TB_Respostas/Create
        public ActionResult Create()
        {
            ViewBag.QuestaoId = new SelectList(db.TB_Questoes, "QuestaoId", "Questao");
            return View();
        }

        // POST: TB_Respostas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TB_Respostas tB_Respostas)
        {
            if (ModelState.IsValid)
            {
                db.TB_Respostas.Add(tB_Respostas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.QuestaoId = new SelectList(db.TB_Questoes, "QuestaoId", "Questao", tB_Respostas.QuestaoId);
            return View(tB_Respostas);
        }

        // GET: TB_Respostas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_Respostas tB_Respostas = db.TB_Respostas.Find(id);
            if (tB_Respostas == null)
            {
                return HttpNotFound();
            }
            ViewBag.QuestaoId = new SelectList(db.TB_Questoes, "QuestaoId", "Questao", tB_Respostas.QuestaoId);
            return View(tB_Respostas);
        }

        // POST: TB_Respostas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TB_Respostas tB_Respostas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tB_Respostas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.QuestaoId = new SelectList(db.TB_Questoes, "QuestaoId", "Questao", tB_Respostas.QuestaoId);
            return View(tB_Respostas);
        }

        // GET: TB_Respostas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_Respostas tB_Respostas = db.TB_Respostas.Find(id);
            if (tB_Respostas == null)
            {
                return HttpNotFound();
            }
            return View(tB_Respostas);
        }

        // POST: TB_Respostas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_Respostas tB_Respostas = db.TB_Respostas.Find(id);
            db.TB_Respostas.Remove(tB_Respostas);
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
