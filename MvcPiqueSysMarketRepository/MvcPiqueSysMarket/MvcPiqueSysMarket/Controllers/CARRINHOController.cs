using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcPiqueSysMarket.Models;

namespace MvcPiqueSysMarket.Controllers
{
    public class CARRINHOController : Controller
    {
        private DBMarket db = new DBMarket();

        // GET: CARRINHOes
        public ActionResult Index()
        {
            return View(db.CARRINHOes.ToList());
        }

        // GET: CARRINHOes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CARRINHO cARRINHO = db.CARRINHOes.Find(id);
            if (cARRINHO == null)
            {
                return HttpNotFound();
            }
            return View(cARRINHO);
        }

        // GET: CARRINHOes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CARRINHOes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ID_PRODUTO,ID_USUARIO")] CARRINHO cARRINHO)
        {
            if (ModelState.IsValid)
            {
                db.CARRINHOes.Add(cARRINHO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cARRINHO);
        }

        // GET: CARRINHOes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CARRINHO cARRINHO = db.CARRINHOes.Find(id);
            if (cARRINHO == null)
            {
                return HttpNotFound();
            }
            return View(cARRINHO);
        }

        // POST: CARRINHOes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ID_PRODUTO,ID_USUARIO")] CARRINHO cARRINHO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cARRINHO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cARRINHO);
        }

        // GET: CARRINHOes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CARRINHO cARRINHO = db.CARRINHOes.Find(id);
            if (cARRINHO == null)
            {
                return HttpNotFound();
            }
            return View(cARRINHO);
        }

        // POST: CARRINHOes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CARRINHO cARRINHO = db.CARRINHOes.Find(id);
            db.CARRINHOes.Remove(cARRINHO);
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
