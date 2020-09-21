using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TourApp.Entity
{
    class DiaDiem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int DDId { set; get; }
        [Required]
        public String MaDD { set; get; }
        [Required]
        public String TenDD { set; get; }
        public ICollection<CTTour> CTTours { set; get; }
    }
}
