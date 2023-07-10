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
        [ValidateInput(false)]
        public ActionResult ThemMoi()
        {
            ViewBag.MaDiaDiem = new SelectList(db.DiaDiems.ToList().OrderBy(n => n.TenDiaDiem), "MaDiaDiem", "TenDiaDiem");
            ViewBag.MaSuKien = new SelectList(db.SuKiens.ToList().OrderBy(n => n.TenSuKien), "MaSuKien", "TenSuKien");
            return View();
        }
        [HttpPost]
        public ActionResult ThemMoi(Ve ve, HttpPostedFileBase fileUpload)
        {
            
            ViewBag.HinhAnh = new SelectList(db.Ves.ToList().OrderBy(n => n.TenVe), "HinhAnh");

            if(fileUpload == null)
            {
                ViewBag.ThongBao = "Chưa chọn file hình ảnh";
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



        //chinh sua
        [HttpGet]

        public ActionResult ChinhSua(int MaVe)
        {
            Ve ve = db.Ves.SingleOrDefault(n => n.MaVe == MaVe);
            if(ve == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            ViewBag.MaDiaDiem = new SelectList(db.DiaDiems.ToList().OrderBy(n => n.TenDiaDiem), "MaDiaDiem", "TenDiaDiem", ve.MaDiaDiem);
            ViewBag.MaSuKien = new SelectList(db.SuKiens.ToList().OrderBy(n => n.TenSuKien), "MaSuKien", "TenSuKien", ve.MaSuKien);
            return View(ve);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ChinhSua(Ve ve)
        {

            if(ModelState.IsValid)
            {
                db.Entry(ve).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

            ViewBag.MaDiaDiem = new SelectList(db.DiaDiems.ToList().OrderBy(n => n.TenDiaDiem), "MaDiaDiem", "TenDiaDiem", ve.MaDiaDiem);
            ViewBag.MaSuKien = new SelectList(db.SuKiens.ToList().OrderBy(n => n.TenSuKien), "MaSuKien", "TenSuKien", ve.MaSuKien);
            ViewBag.MaVe = ve.MaVe;

            return RedirectToAction("Index");
        }


        //hien thi 
        public ActionResult HienThi (int MaVe)
        {
            Ve ve = db.Ves.SingleOrDefault(n => n.MaVe == MaVe);
            if (ve == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(ve);
        }



        //xoa

        [HttpGet]
        public ActionResult Xoa(int MaVe)
        {
            Ve ve = db.Ves.SingleOrDefault(n => n.MaVe == MaVe);
            if (ve == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(ve);
        }
        [HttpPost, ActionName("Xoa")]

        public ActionResult XacNhanXoa(int Mave)
        {
            Ve ve = db.Ves.SingleOrDefault(n=> n.MaVe == Mave);
            if (ve == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            db.Ves.Remove(ve);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}