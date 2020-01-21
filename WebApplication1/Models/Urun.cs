using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Urun
    {

        public int ürünid { get; set; }
        public string ürünadi { get; set; }
        public string aciklama { get; set; }
        public int fiyat { get; set; }
        public bool satistami { get; set; }
        public string  resim { get; set; }
    }
}