using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ModelUrun
    {

        public int count { get; set; }
        public List<Urun> ürünler { get; set; }
        public List<Kategori> kategoriler { get; set; }
    }
}