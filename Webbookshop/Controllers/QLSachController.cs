using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webbookshop.Models;

namespace Webbookshop.Controllers
{
    public class QLSachController : Controller
    {
        private ModelsBookShop _context = new ModelsBookShop();
        // GET: QLSach
        public ActionResult Index()
        {
            var listBook = _context.Saches.ToList();
            return View(listBook);
        }

        public ActionResult BookTheoChuDe(int maCD)
        {
            var ListBook = _context.Saches.Where(x => x.MaChuDe == maCD).ToList();
            var tenCD = from ten in ListBook.Where(t => t.MaChuDe == maCD) select ten;
            ViewBag.Ten = tenCD;
            return View(ListBook);
            
        }

        
    }
}