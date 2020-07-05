using System.ComponentModel.DataAnnotations;

namespace MapDemo.Model
{
    public class Resource : Item
    {
        [Key]
        public int ResourceId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Value must be bigger than 0.")]
        public int Price { get; set; }
    }
}
