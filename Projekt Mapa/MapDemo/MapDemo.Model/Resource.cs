using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapDemo.Model
{
    public class Resource : Item
    {
        [Key]
        public int ResourceId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public float Price { get; set; }
    }
}
