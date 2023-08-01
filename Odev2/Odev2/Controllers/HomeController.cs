using Odev2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Odev2.Controllers
{
    public class HomeController : Controller
    {
        Model1Container db = new Model1Container();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Kitaplar()
        {
            var kitap = db.KitaplarSet.ToList();

            return View(kitap);
        }

        // --- Bize Ulaş
        public ActionResult BizeUlas()
        {
            return View();
        }
    }
}