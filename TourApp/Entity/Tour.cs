using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TourApp.Entity
{
    class Tour
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int TourId { set; get; }
        [Required]
        public String MaTour { set; get; }
        [Required]
        public String Ten { set; get; }
        public ICollection<CTTour> CTTours { set; get; }

    }
}
