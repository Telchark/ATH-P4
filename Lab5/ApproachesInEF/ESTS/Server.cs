using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSES
{
    [Table("Comp")]
    public class Server
    {
        public int ServerId { get; set; }
        public int ComputerId { get; set; }
        public int Bandwidth { get; set; }
        public virtual TSComputer Computer { get; set; }
    }
}
