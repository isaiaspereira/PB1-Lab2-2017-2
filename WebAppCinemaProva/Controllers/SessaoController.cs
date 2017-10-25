﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAppCinemaProva.Models.Cinema;

namespace WebAppCinemaProva.Controllers
{
    public class SessaoController : Controller
    {
        private CinemaContext db = new CinemaContext();

        // GET: Sessao
        public ActionResult Index()
        {
            var sessoes = db.Sessoes.Include(s => s.Filme).Include(s => s.Sala);
            return View(sessoes.ToList());
        }

        // GET: Sessao/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sessao sessao = db.Sessoes.Find(id);
            if (sessao == null)
            {
                return HttpNotFound();
            }
            return View(sessao);
        }

        // GET: Sessao/Create
        public ActionResult Create()
        {
            ViewBag.FilmeId = new SelectList(db.FIlmes, "FilmeId", "Titulo");
            ViewBag.SalaId = new SelectList(db.Salas, "SalaId", "Descricao");
            return View();
        }

        // POST: Sessao/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Sessao sessao)
        {
            if (ModelState.IsValid)
            {
                db.Sessoes.Add(sessao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FilmeId = new SelectList(db.FIlmes, "FilmeId", "Titulo", sessao.FilmeId);
            return View(sessao);
        }

        // GET: Sessao/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sessao sessao = db.Sessoes.Find(id);
            if (sessao == null)
            {
                return HttpNotFound();
            }
            ViewBag.FilmeId = new SelectList(db.FIlmes, "FilmeId", "Titulo", sessao.FilmeId);
            return View(sessao);
        }

        // POST: Sessao/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Sessao sessao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sessao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FilmeId = new SelectList(db.FIlmes, "FilmeId", "Titulo", sessao.FilmeId);
            return View(sessao);
        }

        // GET: Sessao/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sessao sessao = db.Sessoes.Find(id);
            if (sessao == null)
            {
                return HttpNotFound();
            }
            return View(sessao);
        }

        // POST: Sessao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sessao sessao = db.Sessoes.Find(id);
            db.Sessoes.Remove(sessao);
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
