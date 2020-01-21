using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    static class Veritabanı
    {

        static List<Urun> ürünler;

        static Veritabanı()
        {
            ürünler = new List<Urun>()
            {
                new Urun(){ürünid=1, ürünadi="Samsung",aciklama="idare ederidare ederidare ederidare ederidare ederidare ederidare ederidare ederidare ederidare ederidare ederidare ederidare ederidare ederidare ederidare ederidare ederidare ederidare eder",fiyat=1000,satistami=true,resim="samsung.jpg"},
                new Urun(){ürünid=2, ürünadi="Samsung",aciklama="idare eder",fiyat=1000,satistami=true,resim="samsung.jpg"},
                new Urun(){ürünid=3, ürünadi="Samsung",aciklama="idare eder",fiyat=1000,satistami=false,resim="samsung.jpg"},
                new Urun(){ürünid=4, ürünadi="Samsung",aciklama="idare eder",fiyat=1000,satistami=true,resim="samsung.jpg"},
                new Urun(){ürünid=5, ürünadi="iphone",aciklama="idare eder",fiyat=1000,satistami=true,resim="iphone.jpg"},
                new Urun(){ürünid=6, ürünadi="iphone",aciklama="idare eder",fiyat=1000,satistami=false,resim="iphone.jpg"},
                new Urun(){ürünid=7, ürünadi="iphone",aciklama="idare eder",fiyat=1000,satistami=true,resim="iphone.jpg"},
                new Urun(){ürünid=8, ürünadi="iphone",aciklama="idare eder",fiyat=1000,satistami=false,resim="iphone.jpg"},
                new Urun(){ürünid=9, ürünadi="iphone",aciklama="idare eder",fiyat=1000,satistami=true,resim="iphone.jpg"}


            };

        



        }

       public static List<Urun> getir
        {

            get { return ürünler; }

        }

        public static void elemanekle(Urun entitiy)
        {

            ürünler.Add(entitiy);


        }

       
        


    }
}