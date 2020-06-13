using System.Collections.Generic;
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
        public double Weight { get; set; }
        [Required]
        public int ArmorValue { get; set; }
        [Required]
        public int Price { get; set; }

    }
}
