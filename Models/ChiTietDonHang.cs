//------------------------------------------------------------------------------
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
    
    public partial class ChiTietDonHang
    {
        public int MaDonHang { get; set; }
        public int MaVe { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public string DonGia { get; set; }
    
        public virtual DonHang DonHang { get; set; }
        public virtual Ve Ve { get; set; }
    }
}
