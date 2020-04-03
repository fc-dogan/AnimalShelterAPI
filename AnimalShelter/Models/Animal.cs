using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}