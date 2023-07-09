using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSoatVeOnline.Models;

namespace WebSoatVeOnline.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        QuanLySoatVeEntities db = new QuanLySoatVeEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult TicketPartial()
        {
            var listTicket = db.Ves.Take(3).ToList();
            return PartialView(listTicket);
        }
    }
}