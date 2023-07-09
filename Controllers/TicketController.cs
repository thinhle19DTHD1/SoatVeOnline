using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSoatVeOnline.Models;

namespace WebSoatVeOnline.Controllers
{
    public class TicketController : Controller
    {
        // GET: newTicket
        QuanLySoatVeEntities db = new QuanLySoatVeEntities();
        public PartialViewResult TicketPartial()
        {
            var listTicket = db.Ves.Take(3).ToList();
            return PartialView(listTicket);
        }
        //xem chi tiet

        public  ViewResult XemChiTiet(int MaVe=0)
        {
            Ve ve = db.Ves.SingleOrDefault(n => n.MaVe == MaVe);
            if(ve == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(ve);
        }
    }
}