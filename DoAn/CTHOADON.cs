//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn
{
    using System;
    using System.Collections.Generic;
    
    public partial class CTHOADON
    {
        public int MaCTHoaDon { get; set; }
        public Nullable<int> MaHoaDon { get; set; }
        public string TenThuoc { get; set; }
        public string TenDonVi { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<int> TongTien { get; set; }
    
        public virtual HOADON HOADON { get; set; }
    }
}
