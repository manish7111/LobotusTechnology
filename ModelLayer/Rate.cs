using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModelLayer
{
    public class Rate
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int RateId { get; set; }
        [Required]
        public int Kg { get; set; }
        public int Z1 { get; set; }
        public int Z2 { get; set; }
        public int Z3 { get; set; }
        public int Z4 { get; set; }
    }
}
