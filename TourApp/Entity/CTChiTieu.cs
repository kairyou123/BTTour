using System;
using System.Collections.Generic;
using System.Text;

namespace TourApp.Entity
{
    class CTChitieu
    {
        public int CTId { set; get; }
        public virtual ChiTieu ChiTieu { set; get; }
        public int DoanId { set; get; }
        public virtual DoanKhach DoanKhach { set; get; }
        public int TienCT { set; get; }
    }
}
