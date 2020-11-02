using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TourApp.Entity
{
    public class HanhKhach
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int KhachId { set; get; }
        public string MaKhach { set; get; }
        public string Ten { set; get; }
        public string SDT { set; get; }
        public string Email { set; get; }
        public string CMND { set; get; }
        public string DiaChi { set; get; }
        public string GioiTinh { set; get; }
        public string Passport { set; get; }

        public int isDeleted { set; get; }
        public ICollection<CTDoan> CTDoans { set; get; }
    }
}
