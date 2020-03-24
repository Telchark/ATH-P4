using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace lab4
{
    public class Team
    {
        public int id { get; set; }
        public string School { get; set; }
        public string Abbreviation { get; set; }
        public string Conference { get; set; }
        public List<Coach> Coaches { get; set; }
    }
}