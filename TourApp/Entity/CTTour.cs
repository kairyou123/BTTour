using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TourApp.Entity
{
    class CTTour
    {
        public int TourId { set; get; }
        public Tour Tour { set; get; }
        public int DDId { set; get; }
        public DiaDiem DiaDiem { set; get; }
        public String ThongTin { set; get; }

    }
}
