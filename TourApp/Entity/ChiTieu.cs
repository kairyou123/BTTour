using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TourApp.Entity
{
    class ChiTieu
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int CTId { set; get; }
        public String Ten { set; get; }
        public ICollection<CTChitieu> CTChitieus { set; get; }
    }
}
