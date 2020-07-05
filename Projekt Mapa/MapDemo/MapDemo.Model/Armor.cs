using System.ComponentModel.DataAnnotations;

namespace MapDemo.Model
{
    public class Armor : Item
    {
        public enum ArmorType
        {
            Head,
            Body,
            Legs,
            Hands
        }
        [Key]
        public int ArmorId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public ArmorType Type { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Value must be bigger than 0.")]
        public double Weight { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Value must be bigger than 0.")]
        public int ArmorValue { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Value must be bigger than 0.")]
        public int Price { get; set; }

    }
}
