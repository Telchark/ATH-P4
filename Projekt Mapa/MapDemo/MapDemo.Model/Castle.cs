using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MapDemo.Model
{
    public class Castle
    {
        public Castle()
        {
            this.Armors = new HashSet<Armor>();
            this.Weapons = new HashSet<Weapon>();
            this.Resources = new HashSet<Resource>();
        }
        [Key]
        public int CastleId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public virtual ICollection<Armor> Armors { get; set; }
        [Required]
        public virtual ICollection<Weapon> Weapons { get; set; }
        [Required]
        public virtual ICollection<Resource> Resources { get; set; }
    }
}
