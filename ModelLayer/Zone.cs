using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModelLayer
{
    public class Zone
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ZoneId { get; set; }
        [Required]
        public string ZoneName { get; set; }
        [Required]
        public string North { get; set; }
        [Required]
        public string South { get; set; }
        [Required]
        public string East { get; set; }
        [Required]
        public string West { get; set; }
    }
}
