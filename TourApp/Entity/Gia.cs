using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TourApp.Entity
{
    public class Gia
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int GiaId { set; get; }
        [Required]
        public int GiaTri { set; get; }
        [Required]
        public DateTime TGBD { set; get; }
        [Required]
        public DateTime TGKT { set; get; }
        [Required]
        public int TourId { set; get; }
        public Tour Tour { set; get; }

    }
}
