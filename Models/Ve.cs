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

    public partial class Ve
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ve()
        {
            this.DiaDiems = new HashSet<DiaDiem>();
        }

        [Required(ErrorMessage = "Vui lòng nhập mã vé")]
        [Display(Name = "Mã vé")]
        public int MaVe { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên vé")]
        [Display(Name = "tên vé")]
        public string TenVe { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập giá vé")]
        [Display(Name = "Giá vé")]
        public Nullable<decimal> GiaVe { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mô tả")]
        [Display(Name = "Mô tả")]
        public string MoTa { get; set; }
        [Display(Name = "hình ảnh")]
        public string HinhAnh { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "0:dd/mm/yyyy", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Vui lòng nhập ngày cập nhật")]
        [Display(Name = "Ngày cập nhật")]
        public Nullable<System.DateTime> NgayCapNhat { get; set; }
        [Required(ErrorMessage = "Vui lòng số lượng tồn")]
        [Display(Name = "Số lượng tồn")]
        public Nullable<int> SoLuongTon { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mã địa điểm")]
        [Display(Name = "Mã địa điểm")]
        public Nullable<int> MaDiaDiem { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mã sự kiện")]
        [Display(Name = "Mã sự kiện")]
        public Nullable<int> MaSuKien { get; set; }
    
        public virtual ChiTietDonHang ChiTietDonHang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiaDiem> DiaDiems { get; set; }
        public virtual DiaDiem DiaDiem { get; set; }
        public virtual SuKien SuKien { get; set; }
    }
}
