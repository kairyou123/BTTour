using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TourApp.Entity
{
    public class NhanVien
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int NVId { set; get; }
        public String MaNV { set; get; }
        public String Ten { set; get; }
        public String SDT { set; get; }
        public int isDeleted { set; get; }
        public ICollection<NV_VT> NV_VTs { set; get; }
    }
}
