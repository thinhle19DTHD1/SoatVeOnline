using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSoatVeOnline.Models;

namespace WebSoatVeOnline.Controllers
{
    public class TouristLocationController : Controller
    {
        // GET: TouristLocation

        QuanLySoatVeEntities db = new QuanLySoatVeEntities();
        public ActionResult TouristLocationPartial()
        {

            return PartialView(db.DiaDiems.Take(4).ToList());
        }
        public ViewResult VeCuaDiaDiem(int MaDiaDiem=0)
        {
            DiaDiem dd = db.DiaDiems.SingleOrDefault(n => n.MaDiaDiem == MaDiaDiem);
            if(dd==null)
            {
                Response.StatusCode = 404;
                return null;
            }
            List<Ve> lstve = db.Ves.Where(n => n.MaDiaDiem == MaDiaDiem).OrderBy(n => n.GiaVe).ToList();
            if(lstve.Count==0)
            {
                ViewBag.Ve = "Không có vé nào thuộc địa điểm trên";
            }
            return View(lstve);
            
        }
    }
}