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
    public class TB_PesquisaController : Controller
    {
        private DEV_PESQUISA_SATISFACAOEntities db = new DEV_PESQUISA_SATISFACAOEntities();

        // GET: TB_Pesquisa
        public ActionResult Index()
        {
            return View(db.TB_Pesquisa.ToList());
        }

        // GET: TB_Pesquisa/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_Pesquisa tB_Pesquisa = db.TB_Pesquisa.Find(id);
            if (tB_Pesquisa == null)
            {
                return HttpNotFound();
            }
            return View(tB_Pesquisa);
        }

        // GET: TB_Pesquisa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TB_Pesquisa/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PesquisaId,Titulo,Descricao")] TB_Pesquisa tB_Pesquisa)
        {
            if (ModelState.IsValid)
            {
                db.TB_Pesquisa.Add(tB_Pesquisa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tB_Pesquisa);
        }

        // GET: TB_Pesquisa/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_Pesquisa tB_Pesquisa = db.TB_Pesquisa.Find(id);
            if (tB_Pesquisa == null)
            {
                return HttpNotFound();
            }
            return View(tB_Pesquisa);
        }

        // POST: TB_Pesquisa/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PesquisaId,Titulo,Descricao")] TB_Pesquisa tB_Pesquisa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tB_Pesquisa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tB_Pesquisa);
        }

        // GET: TB_Pesquisa/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_Pesquisa tB_Pesquisa = db.TB_Pesquisa.Find(id);
            if (tB_Pesquisa == null)
            {
                return HttpNotFound();
            }
            return View(tB_Pesquisa);
        }

        // POST: TB_Pesquisa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_Pesquisa tB_Pesquisa = db.TB_Pesquisa.Find(id);
            db.TB_Pesquisa.Remove(tB_Pesquisa);
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
