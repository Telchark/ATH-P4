using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace lab4
{
    public class Team
    {
        public Team()
        {
            LogosNavigation = new HashSet<Logo>();
        }
        [Key]
        public int id { get; set; }
        public string School { get; set; }
        public string Abbreviation { get; set; }
        public string? Alt_name1 { get; set; }
        public string? Alt_name2 { get; set; }
        public string? Alt_name3 { get; set; }
        public string Conference { get; set; }
        public string Division { get; set; }
        public string Color { get; set; }
        public string Alt_color { get; set; }
        public int Logos { get; set; }
        public virtual ICollection<Logo> LogosNavigation { get; set; }
    }
}
