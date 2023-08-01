using Odev2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Odev2.Controllers
{
    public class AdminController : Controller
    {
        Model1Container db = new Model1Container();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Kullanicilar kullanici)
        {
            var giris = from x in db.KullanicilarSet where kullanici.KullaniciAdi == x.KullaniciAdi && kullanici.Sifre == x.Sifre select x;
            if (giris.Count() > 0)
            {
                return RedirectToAction("Index", "Kullanicilar");
            }
            else
            {
                
                return RedirectToAction("Index");
            }
        }

    }
}