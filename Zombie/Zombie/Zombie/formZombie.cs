using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zombie
{
    public partial class formZombie : Form
    {
        #region GLOBAL VARIABLES
        List<Zombie> Zombies = new List<Zombie>();
        List<Human> Humans = new List<Human>();
        List<Soldier> Soldiers = new List<Soldier>();
        Random rnd = new Random();
        #endregion
        #region TOOL TIP ADDERS
        private void SetToolTipHuman(Human human)
        {
            var tTip = new ToolTip();
            tTip.SetToolTip(human, $"Human\nX: {human.Left}\nY: {human.Top}\nMoney: {human.Money}");
        }
        private void SetToolTipZombie(Zombie zombie)
        {
            var tTip = new ToolTip();
            tTip.SetToolTip(zombie, $"Zombie\nX: {zombie.Left}\nY: {zombie.Top}\nMoney: {zombie.Money}\nDays to cure: {zombie.DaysToCure}\nStrength: {zombie.Strength}");
        }
        private void SetToolTipSoldier(Soldier soldier)
        {
            var tTip = new ToolTip();
            tTip.SetToolTip(soldier, $"Soldier\nX: {soldier.Left}\nY: {soldier.Top}\nMoney: {soldier.Money}\nStamina: {soldier.Stamina}");
        }
        #endregion
        private void Moving(int moveTick, Button item)
        {
            if (rnd.Next(2) == 1)
                moveTick *= -1;
            if (rnd.Next(2) == 1)
            {
                if (!(item.Left + moveTick > 500 || item.Left + moveTick < 20))
                    item.Left += moveTick;

            }
            else
            {
                if (!(item.Top + moveTick > 500 || item.Top + moveTick < 20))
                    item.Top += moveTick;
            }
        }
        public formZombie()
        {
            InitializeComponent();
        }

        private void btnNextTurn_Click(object sender, EventArgs e)
        {
            btnNextTurn.Enabled = false;
            #region MOVE PHASE
            foreach (var item in Soldiers)
            {
                Moving(20, item);
                SetToolTipSoldier(item);
            }
            foreach (var item in Humans)
            {
                if (item.Money > 0)
                {
                    Moving(20, item);
                    item.Money--;
                    SetToolTipHuman(item);
                }
            }
            foreach (var item in Zombies)
            {
                Moving(20, item);
                item.DaysToCure--;
                SetToolTipZombie(item);
            }
            #endregion
            #region FIGHT PHASE
            //cywil zombie i żołnierz spotykają się na jednym polu żołnierz bije zombie 
            //jeśli żołnierz padnie zombie zaraża cywila jesli nie pyta cywila o środki dla wojka 
            //jeśli cywil takowych nie posiada wciela go do armii
            for (int i = 0; i < Soldiers.Count; i++)
            {
                var checkForZombie = Zombies.Where(x => x.Left == Soldiers[i].Left && x.Top == Soldiers[i].Top).ToList();
                if (checkForZombie.Count > 0)
                {
                    for (int j = 0; j < checkForZombie.Count; j++)
                    {
                        if (Soldiers[i].Stamina < checkForZombie[j].Strength)
                        {
                            Zombies.Add(new Zombie(Soldiers[i].Left, Soldiers[i].Top, Soldiers[i].Money, rnd.Next(1, 30), rnd.Next(1, 10)));
                            this.Controls.Add(Zombies.Last());
                            SetToolTipZombie(Zombies.Last());
                            this.Controls.Remove(Soldiers[i]);
                            Soldiers.RemoveAt(i);
                            break; //soldier died
                        }else
                        {
                            Soldiers[i].Stamina -= checkForZombie[j].Strength;
                            Humans.Add(new Human(checkForZombie[j].Left, checkForZombie[j].Top, checkForZombie[j].Money));
                            this.Controls.Add(Humans.Last());
                            SetToolTipHuman(Humans.Last());
                            this.Controls.Remove(checkForZombie[j]);
                            Zombies.Remove(checkForZombie[j]);
                        }
                    }

                }
            }
            for (int i = 0; i < Humans.Count; i++)
            {
                var checkForZombie = Zombies.Where(x => x.Left == Humans[i].Left && x.Top == Humans[i].Top).ToList();
                if (checkForZombie.Count > 0)
                {
                    Zombies.Add(new Zombie(Humans[i].Left, Humans[i].Top, Humans[i].Money, rnd.Next(1, 30), rnd.Next(1, 10)));
                    this.Controls.Add(Zombies.Last());
                    SetToolTipZombie(Zombies.Last());
                    this.Controls.Remove(Humans[i]);
                    Humans.RemoveAt(i);
                    continue;
                }
                var checkForSoldier = Soldiers.Where(x => x.Left == Humans[i].Left && x.Top == Humans[i].Top).ToList();
                if(checkForSoldier.Count > 0)
                {
                    if (Humans[i].Money < rnd.Next(1, 8))
                        {
                        Soldiers.Add(new Soldier(Humans[i].Left, Humans[i].Top, Humans[i].Money, rnd.Next(1, 20)));
                        this.Controls.Add(Soldiers.Last());
                        this.Controls.Remove(Humans[i]);
                        Humans.RemoveAt(i);
                        }
                }
            }
            for (int i = 0; i < Zombies.Count; i++)
            {
                if (Zombies[i].DaysToCure == 0)
                {
                    Humans.Add(new Human(Zombies[i].Left, Zombies[i].Top, Zombies[i].Money));
                    this.Controls.Add(Humans.Last());
                    SetToolTipHuman(Humans.Last());
                    this.Controls.Remove(Zombies[i]);
                    Zombies.Remove(Zombies[i]);
                }
            }
            #endregion
            btnNextTurn.Enabled = true;

        }
        #region GENERATE INITIAL UNITS
        private void btnStart_Click(object sender, EventArgs e)
        {
            int initialAmountOfHumans = 0;
            int initialAmountOfZombies = 0;
            int initialAmountOfSuperHeavyAntiZombieSoldat = 0;
            if (Int32.TryParse(tBHumans.Text, out initialAmountOfHumans) && Int32.TryParse(tBZombies.Text, out initialAmountOfZombies) && Int32.TryParse(tBSoldiers.Text, out initialAmountOfSuperHeavyAntiZombieSoldat))
            {
                for (int i = 0; i < initialAmountOfHumans; i++)
                {
                    Humans.Add(new Human(20 + 20 * rnd.Next(0, 24), 20 + 20 * rnd.Next(0, 24), rnd.Next(0, 30)));
                    this.Controls.Add(Humans.Last());
                    SetToolTipHuman(Humans.Last());
                }
                for (int i = 0; i < initialAmountOfZombies; i++)
                {
                    Zombies.Add(new Zombie(20 + 20 * rnd.Next(0, 24), 20 + 20 * rnd.Next(0, 24), rnd.Next(0, 30), rnd.Next(1, 30), rnd.Next(1, 10)));
                    this.Controls.Add(Zombies.Last());
                    SetToolTipZombie(Zombies.Last());
                }
                for (int i = 0; i < initialAmountOfSuperHeavyAntiZombieSoldat; i++)
                {
                    Soldiers.Add(new Soldier(20 + 20 * rnd.Next(0, 24), 20 + 20 * rnd.Next(0, 24), rnd.Next(0, 30), rnd.Next(1, 20)));
                    this.Controls.Add(Soldiers.Last());
                    SetToolTipSoldier(Soldiers.Last());
                }
                btnStart.Enabled = false;
            }
            else
            {
                MessageBox.Show("Złe dane");
            }
            #endregion
        }
    }
}