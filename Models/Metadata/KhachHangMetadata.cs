using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebSoatVeOnline.Models.Metadata
{
    [MetadataTypeAttribute(typeof(KhachHangMetadata))]
    public class KhachHangMetadata
    {
        internal sealed class KhachHangtadata
        {
            [Required(ErrorMessage = "Vui lòng nhập mã khách hàng")]
            [Display(Name = "Mã khách hàng")]
            public int MaKH { get; set; }
            [Required(ErrorMessage = "Vui lòng nhập họ tên")]
            [Display(Name = "Họ tên")]
            public string HoTen { get; set; }
            [Required(ErrorMessage = "Vui lòng nhập tài khoản")]
            [Display(Name = "Tài khoản")]
            public string TaiKhoan { get; set; }
            [Required(ErrorMessage = "Vui lòng nhập Số mật khẩu")]
            [Display(Name = "Mật khẩu")]
            public string MatKhau { get; set; }
            [Required(ErrorMessage = "Vui lòng nhập email")]
            [Display(Name = "Email")]
            public string Email { get; set; }
            [Required(ErrorMessage = "Vui lòng nhập địa chỉ")]
            [Display(Name = "Địa chỉ")]
            public string DiaChi { get; set; }
            [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
            [Display(Name = "Điện thoại")]
            public string DienThoai { get; set; }
            [Required(ErrorMessage = "Vui lòng nhập giới tính")]
            [Display(Name = "Giới tính")]
            public string GioiTinh { get; set; }
            [Required(ErrorMessage = "Vui lòng nhập ngày sinh")]
            [Display(Name = "Ngày sinh")]
            public Nullable<System.DateTime> NgaySinh { get; set; }
        }
    }
}