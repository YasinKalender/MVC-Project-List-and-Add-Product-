using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult kategoriler()
        {


            List<Kategori> kategoriler = new List<Kategori>()
            {

                new Kategori(){kategori="Telefon"},
                new Kategori(){kategori="Tablet"},
                new Kategori(){kategori="Bilgisayar"}


            };

            return PartialView("kategoriler", kategoriler);

        }
    }
}