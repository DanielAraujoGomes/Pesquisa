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
    public class TB_AlternativasController : Controller
    {
        private DEV_PESQUISA_SATISFACAOEntities db = new DEV_PESQUISA_SATISFACAOEntities();

        // GET: TB_Alternativas
        public ActionResult Index()
        {
            var TB_Alternativas = db.TB_Alternativas.Include(t => t.TB_Questoes);
            return View(TB_Alternativas.ToList());
        }

        // GET: TB_Alternativas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_Alternativas TB_Alternativas = db.TB_Alternativas.Find(id);
            if (TB_Alternativas == null)
            {
                return HttpNotFound();
            }
            return View(TB_Alternativas);
        }

        // GET: TB_Alternativas/Create
        public ActionResult Create()
        {
            ViewBag.QuestaoId = new SelectList(db.TB_Questoes, "QuestaoId", "Questao");
            return View();
        }

        // POST: TB_Alternativas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AlternativaId,QuestaoId,Alternativa")] TB_Alternativas TB_Alternativas)
        {
            if (ModelState.IsValid)
            {
                db.TB_Alternativas.Add(TB_Alternativas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.QuestaoId = new SelectList(db.TB_Questoes, "QuestaoId", "Questao", TB_Alternativas.QuestaoId);
            return View(TB_Alternativas);
        }

        // GET: TB_Alternativas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_Alternativas TB_Alternativas = db.TB_Alternativas.Find(id);
            if (TB_Alternativas == null)
            {
                return HttpNotFound();
            }
            ViewBag.QuestaoId = new SelectList(db.TB_Questoes, "QuestaoId", "Questao", TB_Alternativas.QuestaoId);
            return View(TB_Alternativas);
        }

        // POST: TB_Alternativas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AlternativaId,QuestaoId,Alternativa")] TB_Alternativas TB_Alternativas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(TB_Alternativas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.QuestaoId = new SelectList(db.TB_Questoes, "QuestaoId", "Questao", TB_Alternativas.QuestaoId);
            return View(TB_Alternativas);
        }

        // GET: TB_Alternativas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_Alternativas TB_Alternativas = db.TB_Alternativas.Find(id);
            if (TB_Alternativas == null)
            {
                return HttpNotFound();
            }
            return View(TB_Alternativas);
        }

        // POST: TB_Alternativas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_Alternativas TB_Alternativas = db.TB_Alternativas.Find(id);
            db.TB_Alternativas.Remove(TB_Alternativas);
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
