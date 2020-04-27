using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombie
{
    public class Zombie :Human
    {
        public Zombie(int x, int y, int money, int initalDaysToCure, int initialStrength) : base(x, y, money)
        {
            Strength = initialStrength;
            DaysToCure = initalDaysToCure;
            BackColor = Color.Green;
        }
        private int _strength;
        public int Strength { 
            get 
            {
                return _strength;
            } 
            set 
            {
                if (value < 0)
                    _strength = 0;
                else
                    _strength = value;
            } 
        }
        public int _daysToCure;
        public int DaysToCure
        {
            get
            {
                return _daysToCure;
            }
            set
            {
                if (value < 0)
                    _daysToCure = 0;
                else
                    _daysToCure = value;
            }
        }

        public void Cure()
        {
            if(DaysToCure == 0)
            {
            }
        }
    }
}
