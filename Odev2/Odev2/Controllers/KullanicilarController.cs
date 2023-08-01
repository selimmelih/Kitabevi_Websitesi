using Odev2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Odev2.Controllers
{
    public class KullanicilarController : Controller
    {
        Model1Container db = new Model1Container();

        // GET: Kullanicilar
        public ActionResult Index()
        {
            return View(db.KullanicilarSet.ToList());
        }
        // --- kaydetme islemi ---
        public ActionResult Kaydetme()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Kaydetme(Kullanicilar kullanici)
        {
            db.KullanicilarSet.Add(kullanici);//viewdeki modele, modeldeki alanla eşleşip kullanici adıyla actionResult a düşer o da tabloya ekler
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //____Guncelle----
        public ActionResult Duzenleme(int id)
        {
            var duzenle = db.KullanicilarSet.Where(x=>x.KullaniciID==id).FirstOrDefault();
            return View(duzenle);
        }
        [HttpPost]
        public ActionResult Duzenleme(Kullanicilar kullanici, int id)
        {
            db.KullanicilarSet.AddOrUpdate(kullanici);//viewdeki modele, modeldeki alanla eşleşip kullanici adıyla actionResult a düşer o da tabloya ekler
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // ----- Silme İşlemi----
        public ActionResult Silme(int id)
        {
            var sil = db.KullanicilarSet.Where(x => x.KullaniciID == id).FirstOrDefault();
            db.KullanicilarSet.Remove(sil);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}