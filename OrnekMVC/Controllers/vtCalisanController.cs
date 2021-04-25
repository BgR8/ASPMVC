using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrnekMVC.Models;

namespace OrnekMVC.Controllers
{
    public class vtCalisanController : Controller
    {
        [NonAction]
        public static List<vtCalisan> GetCalisanList()
        {
            return new List<vtCalisan>
            {
                new vtCalisan
                {
                    ID = 1,
                    isim = "BgR",
                    tarih = DateTime.Parse(DateTime.Today.ToString()),
                    yas = 27
                },
                new vtCalisan
                {
                    ID = 2,
                    isim = "ABC",
                    tarih = DateTime.Parse(DateTime.Today.ToString()),
                    yas = 27
                },
                new vtCalisan
                {
                    ID = 3,
                    isim = "Deneme",
                    tarih = DateTime.Parse(DateTime.Today.ToString()),
                    yas = 20
                },
                new vtCalisan
                {
                    ID = 4,
                    isim = "GS",
                    tarih = DateTime.Parse(DateTime.Today.ToString()),
                    yas = 37
                },
            };
        }
        
        // GET: vtCalisan
        public ActionResult Index()
        {
            var vtcalisanlar = from e in GetCalisanList()
                            orderby e.ID
                            select e;
            return View(vtcalisanlar);
        }

        // GET: vtCalisan/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: vtCalisan/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: vtCalisan/Create
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

        // GET: vtCalisan/Edit/5
        public ActionResult Edit(int id)
        {
            List<vtCalisan> clnListe = GetCalisanList();
            var calisan = clnListe.Single(m => m.ID == id);
            return View(calisan);
        }

        // POST: vtCalisan/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                var vtCalisan = GetCalisanList().Single(m => m.ID == id);
                if(TryUpdateModel(vtCalisan))
                {
                    //To Do:- database code
                    return RedirectToAction("Index");
                }

                return View(vtCalisan);
            }
            catch
            {
                return View();
            }
        }

        // GET: vtCalisan/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: vtCalisan/Delete/5
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
