using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webbookshop.Areas.Admin.Data;
using Webbookshop.Models;

namespace Webbookshop.Areas.Admin.Controllers
{
    public class QLChuDeAdminController : Controller
    {
        // GET: Admin/QLChuDeAdmin
        private ModelsBookShop _context = new ModelsBookShop();
        public ActionResult Index()
        {
            var listChuDe = (from cd in _context.ChuDes
                             orderby cd.TenChuDe
                             select new ChuDeAdminViewModel()
                             {
                                 MaCD = cd.MaChuDe,
                                 TenCD = cd.TenChuDe
                             }).ToList();
            return View(listChuDe);
        }
    }
}