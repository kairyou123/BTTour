using System;
using System.Collections.Generic;
using System.Text;

namespace TourApp.Entity
{
    public class NV_VT
    {
        public int DoanId { set; get; }
        public DoanKhach DoanKhach { set; get; }
        public int NVId { set; get; }
        public NhanVien NhanVien { set; get; }
        public String ViTri { set; get; }
    }
}
