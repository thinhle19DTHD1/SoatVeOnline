﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSoatVeOnline.Models
{
    using System;
    using System.Collections.Generic;

    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            this.DonHangs = new HashSet<DonHang>();
        }

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
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHangs { get; set; }
    }
}
