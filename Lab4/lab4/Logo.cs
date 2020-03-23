using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace lab4
{
    public class Logo
    {
        [Key]
        public int LogoId { get; set; }
        public int? TeamId { get; set; }
        public string Link { get; set; }
        public virtual Team Team { get; set; }
    }
}
