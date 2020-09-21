using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace TourApp.Entity
{
    class DoanKhach
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int DoanId { set; get; }
        public String MaDoan { set; get; }
        public String TenDoan { set; get; }
        [AllowNull]
        public String Chitiet { set; get; }
        public String Status { set; get; }
        public int TourId { set; get; }
        public Tour Tour { set; get; }
        public ICollection<CTDoan> CTDoans { set; get; }
        public ICollection<NV_VT> NV_VTs { set; get; }
        public ICollection<CTChitieu> CTChitieus { set; get; }
    }
}
