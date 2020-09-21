using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TourApp.Entity
{
    class HanhKhach
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int KhachId { set; get; }
        public String MaKhach { set; get; }
        public String Ten { set; get; }
        public int SDT { set; get; }
        public String Email { set; get; }
        public ICollection<CTDoan> CTDoans { set; get; }
    }
}
