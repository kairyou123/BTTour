using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TourApp.Entity
{
    class LoaiHinhDL
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int LHDLId { set; get; }
        [Required]
        public String Ten { set; get; }
        public String moTa { set; get; }
        public ICollection<Tour> Tours { set; get; }

    }
}
