using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using WebSoatVeOnline.Models;


namespace WebSoatVeOnline.Controllers
{
    public class TicketManageController : Controller
    {
        // GET: TicketManage

        QuanLySoatVeEntities db = new QuanLySoatVeEntities();
        public ActionResult Index(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 10;
            return View(db.Ves.ToList().OrderBy(n=>n.MaVe).ToPagedList(pageNumber,pageSize));
        }

        //them 
        [HttpGet]
        public ActionResult ThemMoi()
        {
            ViewBag.MaDiaDiem = new SelectList(db.DiaDiems.ToList().OrderBy(n => n.TenDiaDiem), "MaDiaDiem", "TenDiaDiem");
            ViewBag.MaSuKien = new SelectList(db.SuKiens.ToList().OrderBy(n => n.TenSuKien), "MaSuKien", "TenSuKien");
            return View();
        }
        [HttpPost]
        public ActionResult ThemMoi(Ve ve,HttpPostedFileBase fileUpload)
        {
            
            ViewBag.HinhAnh = new SelectList(db.Ves.ToList().OrderBy(n => n.TenVe), "HinhAnh");

            if(fileUpload == null)
            {
                ViewBag.ThongBao = "Nhua chọn file hình ảnh";
                return View();
            }

            if(ModelState.IsValid)
            {
                var fileName = Path.GetFileName(fileUpload.FileName);
                var path = Path.Combine(Server.MapPath("~/images"), fileName);

                if (System.IO.File.Exists(path))
                {
                    ViewBag.ThongBao = "Ảnh vé đã tồn tại";
                }
                else
                {
                    fileUpload.SaveAs(path);
                }
                ve.HinhAnh = fileUpload.FileName;

                db.Ves.Add(ve);
                db.SaveChanges();
            }


            return View();
        }

    }
}