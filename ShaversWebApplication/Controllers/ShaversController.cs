using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShaversWebApplication.Controllers
{
    public class ShaversController : Controller
    {
        // GET: Shavers
        public ActionResult Index()
        {
            return View();
        }
    }
}