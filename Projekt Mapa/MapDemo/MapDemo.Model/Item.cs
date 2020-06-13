using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MapDemo.Model
{
    public class Item
    {
        public Item()
        {
            this.Castles = new HashSet<Castle>();
        }
        [Required]
        public virtual ICollection<Castle> Castles { get; set; }
    }
}
