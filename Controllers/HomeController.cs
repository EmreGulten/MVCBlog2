using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogMvcApp.Models;

namespace BlogMvcApp.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext context = new BlogContext();
        // GET: Home
        public ActionResult Index()
        {
            var bloglar = context.Bloglar.Where(x => x.AnaSayfa == true && x.Onay == true)
                .Select(x => new BlogModel()
            {
                ID = x.ID,
                Baslik = x.Baslik.Length > 100 ? x.Baslik.Substring(0, 100) + "..." : x.Baslik,
                Aciklama = x.Aciklama,
                AnaSayfa = x.AnaSayfa,
                Onay = x.Onay,
                EklemeTarihi = x.EklemeTarihi,
                Resim = x.Resim

            });

            return View(bloglar.ToList());
        }
    }
}