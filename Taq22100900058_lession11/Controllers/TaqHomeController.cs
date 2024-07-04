using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Taq22100900058_lession11.Controllers
{
    public class TaqHomeController : Controller
    {
        public ActionResult TaqIndex()
        {
            return View();
        }

        public ActionResult TaqAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult TaqContact()
        {
            ViewBag.msv = "2210900058";
            ViewBag.fullname = "truong anh quan ";

            return View();
        }
    }
}