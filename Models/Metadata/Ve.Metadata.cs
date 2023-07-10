using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace WebSoatVeOnline.Models.Metadata
{
    [MetadataTypeAttribute(typeof(VeMetadata))]
    public class Ve
    {
        internal sealed class VeMetadata
        {
            [Required(ErrorMessage ="Vui lòng nhập mã vé")]
            [Display(Name ="Mã vé")]
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
        }
    }
}