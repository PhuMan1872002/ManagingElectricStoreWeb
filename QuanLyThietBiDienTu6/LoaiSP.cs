//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyThietBiDienTu6
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoaiSP
    {
        public LoaiSP()
        {
            this.SANPHAMs = new HashSet<SANPHAM>();
        }
    
        public int MaLoaiSP { get; set; }
        public string TenLoaiSP { get; set; }
    
        public virtual ICollection<SANPHAM> SANPHAMs { get; set; }
    }
}