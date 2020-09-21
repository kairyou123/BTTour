using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TourApp.Entity
{
    class Gia
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int GiaId { set; get; }
        [Required]
        public String MaGia { set; get; }
        [Required]
        public int GiaTri { set; get; }
        [Required]
        public DateTime TGBD { set; get; }
        [Required]
        public DateTime TGKT { set; get; }
        public int TourId { set; get; }
        public Tour Tour { set; get; }

    }
}
