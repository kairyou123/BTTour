using System;
using System.Collections.Generic;
using System.Text;

namespace TourApp.Entity
{
    class CTDoan
    {
        public int DoanId { set; get; }
        public DoanKhach DoanKhach { set; get; }
        public int KhachId { set; get; }
        public HanhKhach HanhKhach { set; get; }
    }
}
