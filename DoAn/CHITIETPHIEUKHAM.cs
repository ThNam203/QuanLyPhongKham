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
    
    public partial class CHITIETPHIEUKHAM
    {
        public int MaChiTietPhieuKham { get; set; }
        public Nullable<int> MaPhieuKham { get; set; }
        public Nullable<int> MaThuoc { get; set; }
        public Nullable<int> MaDonVi { get; set; }
        public Nullable<int> MaCachDung { get; set; }
        public Nullable<int> SoLuong { get; set; }
    
        public virtual CACHDUNG CACHDUNG { get; set; }
        public virtual DONVI DONVI { get; set; }
        public virtual PHIEUKHAM PHIEUKHAM { get; set; }
        public virtual THUOC THUOC { get; set; }
    }
}