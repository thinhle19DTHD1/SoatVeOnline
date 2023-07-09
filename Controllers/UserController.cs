using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSoatVeOnline.Models;

namespace WebSoatVeOnline.Controllers
{
    public class UserController : Controller
    {
        QuanLySoatVeEntities db = new QuanLySoatVeEntities();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]

        public ActionResult DangKy()
        {

            return View();
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult DangKy(KhachHang kh)
        {
            if (ModelState.IsValid)
            {

                db.KhachHangs.Add(kh);
                db.SaveChanges();
            }
            return View();

        }

        [HttpGet]
        public ActionResult DangNhap()
        {
     
            return View();
        }

        [HttpPost]
        public ActionResult DangNhap(FormCollection f)
        {
            string sTaiKhoan = f["txtTaiKhoan"].ToString();
            string sMatKhau = f["txtMatKhau"].ToString();
            KhachHang kh = db.KhachHangs.SingleOrDefault(n => n.TaiKhoan == sTaiKhoan && n.MatKhau == sMatKhau);
            if(kh != null)
            {
                ViewBag.ThongBao = "Đăng nhập thành công!";
                Session["TaiKhoan"] = kh;
                return View();
            }
            ViewBag.ThongBao = "Tên đăng nhập hoặc tài khoản không đúng.";
            return View();
        }
    }
}