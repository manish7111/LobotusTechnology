using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelLayer
{
    public class City
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int CityId { get; set; }
        [Required]
        [ForeignKey("Direction")]
        public int DirectionId { get; set; }
        [Required]
        public string CityName { get; set; }
    }
}
