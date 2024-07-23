using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webbookshop.Models;

namespace Webbookshop.Controllers
{
    public class ChuDeController : Controller
    {
        private ModelsBookShop _context = new ModelsBookShop();
        // GET: ChuDe
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MenuLeft()
        {
            var chude = _context.ChuDes.ToList();
            return PartialView(chude);
        }
    }
}