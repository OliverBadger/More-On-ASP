using System.ComponentModel.DataAnnotations;

namespace MyThirdASP.NET.Models
{
    public class Pet
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string Name { get; set; }
        public string Colour{ get; set; }
        public DateTime DOB { get; set; }
        public string Sound { get; set; }
        public string SoundType { get; set; }
    }
}
