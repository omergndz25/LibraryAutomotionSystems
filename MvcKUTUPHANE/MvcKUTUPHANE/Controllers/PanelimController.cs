using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKUTUPHANE.Controllers
{
    public class PanelimController : Controller
    {
        // GET: Panelim
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}