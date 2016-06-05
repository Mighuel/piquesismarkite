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
    public class HomeController : Controller
    {
        private DBMarket db = new DBMarket();
        // GET: Home
        public ActionResult Index(USUARIO u)
        {
            var senha = u.SENHA;
            var v = db.USUARIO.Where(x => x.E_MAIL.Equals(u.E_MAIL) && x.SENHA.Equals(senha)).FirstOrDefault();

            if (v != null)
            {
                Session["USERID"] = v.ID.ToString();
                Session["USER"] = v.E_MAIL.ToString();

                return RedirectToAction("index", "Produto");
            }
            
            return View();
        }


        public ActionResult Login(USUARIO u)
        {
            
            if (ModelState.IsValid)
            {
                var senha = u.SENHA;
                var v = db.USUARIO.Where(x => x.E_MAIL.Equals(u.E_MAIL) && x.SENHA.Equals(senha)).FirstOrDefault();

                if (v != null)
                {
                    Session["USERID"] = v.ID.ToString();
                    Session["USER"] = v.E_MAIL.ToString();

                    return RedirectToAction("index", "Produto");
                }
            }


            return View();
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
