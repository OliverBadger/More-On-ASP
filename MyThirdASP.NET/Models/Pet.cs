using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyThirdASP.NET.Models
{
    public class Pet
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [Display(Name = "Pet Name")]
        [Column(TypeName = "varchar(100)")]
        [StringLength(100)]
        public string Name { get; set; }
        public string Colour{ get; set; }
        public DateTime DOB { get; set; }
        public string Sound { get; set; }
        public string SoundType { get; set; }
    }
}
