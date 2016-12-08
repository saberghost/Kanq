using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kanq.Model;

namespace Kanq.WebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //OracleDbContext db = new OracleDbContext();
            //var model= db.TBL_JSYDBP_BCGDDJK_ZB1.FirstOrDefault();
            //ViewBag.Name = model.BCGDDJKID;
            return View();
        }
    }
}