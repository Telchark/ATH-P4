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
        public int Price { get; set; }
    }
}
