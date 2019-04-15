using System.ComponentModel.DataAnnotations;

namespace RescueRegister.Models
{
    public class Mountaineer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(1, int.MaxValue)]
        public int Age { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string LastSeenDate { get; set; }
    }
}
