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
    public class TB_ParticipantesController : Controller
    {
        private DEV_PESQUISA_SATISFACAOEntities db = new DEV_PESQUISA_SATISFACAOEntities();

        // GET: TB_Participantes
        public ActionResult Index()
        {
            var tB_Participantes = db.TB_Participantes.Include(t => t.TB_Pesquisa);
            return View(tB_Participantes.ToList());
        }

        // GET: TB_Participantes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_Participantes tB_Participantes = db.TB_Participantes.Find(id);
            if (tB_Participantes == null)
            {
                return HttpNotFound();
            }
            return View(tB_Participantes);
        }

        // GET: TB_Participantes/Create
        public ActionResult Create()
        {
            ViewBag.PesquisaId = new SelectList(db.TB_Pesquisa, "PesquisaId", "Titulo");
            return View();
        }

        // POST: TB_Participantes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ParticipanteId,PesquisaId,Nome,Email")] TB_Participantes tB_Participantes)
        {
            if (ModelState.IsValid)
            {
                db.TB_Participantes.Add(tB_Participantes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PesquisaId = new SelectList(db.TB_Pesquisa, "PesquisaId", "Titulo", tB_Participantes.PesquisaId);
            return View(tB_Participantes);
        }

        // GET: TB_Participantes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_Participantes tB_Participantes = db.TB_Participantes.Find(id);
            if (tB_Participantes == null)
            {
                return HttpNotFound();
            }
            ViewBag.PesquisaId = new SelectList(db.TB_Pesquisa, "PesquisaId", "Titulo", tB_Participantes.PesquisaId);
            return View(tB_Participantes);
        }

        // POST: TB_Participantes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ParticipanteId,PesquisaId,Nome,Email")] TB_Participantes tB_Participantes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tB_Participantes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PesquisaId = new SelectList(db.TB_Pesquisa, "PesquisaId", "Titulo", tB_Participantes.PesquisaId);
            return View(tB_Participantes);
        }

        // GET: TB_Participantes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_Participantes tB_Participantes = db.TB_Participantes.Find(id);
            if (tB_Participantes == null)
            {
                return HttpNotFound();
            }
            return View(tB_Participantes);
        }

        // POST: TB_Participantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_Participantes tB_Participantes = db.TB_Participantes.Find(id);
            db.TB_Participantes.Remove(tB_Participantes);
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
