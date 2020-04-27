using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombie
{
    public class Soldier : Human
    {
        public Soldier(int x, int y, int money, int initialStamina) : base(x, y, money)
        {
            Stamina = initialStamina;
            BackColor = Color.Gold;
        }
        private int _stamina;
        public int Stamina
        {
            get
            {
                return _stamina;
            }
            set
            {
                if (value < 0)
                    _stamina = 0;
                else
                    _stamina = value;
            }
        }
    }
}
