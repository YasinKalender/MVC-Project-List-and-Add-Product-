using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {


           

            ModelUrun model = new ModelUrun();
            model.count = Veritabanı.getir.Where(i=>i.satistami==true).Count();
            model.ürünler = Veritabanı.getir.Where(i => i.satistami == true).ToList();
            


            //ViewBag.count = ürünler.Count();
            //ViewBag.kategori = kategoriler;


            return View(model);
        }
        [HttpGet]
        public ActionResult ürünekle()
        {



            return View();
        }
        [HttpPost]
        public ActionResult ürünekle(/*string ürünadi,string aciklama,int fiyat, string resim,bool satistami*/ Urun entity)
        {

            //Urun entity = new Urun();
            //entity.ürünadi = ürünadi;
            //entity.aciklama = aciklama;
            //entity.fiyat = fiyat;
            //entity.resim = resim;
            //entity.satistami = satistami;


            Veritabanı.elemanekle(entity);

            return View("UrunListe", Veritabanı.getir);

           

        }

        public ActionResult Details(int id)
        {

           var urun =  Veritabanı.getir.Where(i => i.ürünid == id).FirstOrDefault();


            return View(urun);

        }

        public ActionResult about()
        {


            return View();
        }

        public ActionResult contact()
        {


            return View();

        }
    }
}