using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TransportRentalSystem.Controllers
{
    public class JournalsController : Controller
    {
        // GET: Journals
        public ActionResult Index()
        {
            return View();
        }
    }
}