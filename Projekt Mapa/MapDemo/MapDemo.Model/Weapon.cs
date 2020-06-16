using System.ComponentModel.DataAnnotations;

namespace MapDemo.Model
{
    //Broń 
    //TODO wrzucenie typów do bazy
    public class Weapon : Item
    {
        public enum WeaponType
        {
            Polearm,
            One_handed,
            Two_handed
        }
        [Key]
        public int WeaponId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public WeaponType Type { get; set; }
        [Required]
        public double Weight { get; set; }
        [Required]
        public int Length { get; set; }
        [Required]
        public int Damage { get; set; }
        [Required]
        public int Price { get; set; }
    }
}
