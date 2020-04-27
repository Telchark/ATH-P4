using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zombie
{
    public class Human : Button
    {
        public Human(int x, int y, int money)
        {
            Width = 20;
            Height = 20;
            BackColor = Color.Blue;
            Left = x;
            Top = y;
            Money = money;
        }
        private int _money;
        public int Money
        {
            get
            {
                return _money;
            }
            set
            {
                if (value < 0)
                    _money = 0;
                else
                    _money = value;
            }
        }


    }
}
