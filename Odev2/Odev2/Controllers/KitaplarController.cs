using Odev2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Odev2.Controllers
{
    public class KitaplarController : Controller
    {
        Model1Container db = new Model1Container();
        // GET: Kitaplar
        public ActionResult Index()
        {
            return View(db.KitaplarSet.ToList());
            //2.46 da kaldık görünüm olsuturmak
        }

        //-- Kaydetme İşlemi--
        public ActionResult Kaydetme()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Kaydetme(Kitaplar kitap)
        {
            db.KitaplarSet.Add(kitap);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}