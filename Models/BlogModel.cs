using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogModel
    {
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
        
        public DateTime EklemeTarihi { get; set; }
        public bool Onay { get; set; }
        public bool AnaSayfa { get; set; }
        public int CategoryId { get; set; }
    }
}