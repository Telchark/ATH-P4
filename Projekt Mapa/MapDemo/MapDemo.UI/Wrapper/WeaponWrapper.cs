using MapDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MapDemo.Model.Weapon;

namespace MapDemo.UI.Wrapper
{
    public class WeaponWrapper : ModelWrapper<Weapon>
    {
        public WeaponWrapper(Weapon model) : base(model)
        {
        }

        public int WeaponId { get { return Model.WeaponId; } }

        public string Name
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public WeaponType Type
        {
            get { return GetValue<WeaponType>(); }
            set { SetValue(value); }
        }

        public double Weight
        {
            get { return GetValue<double>(); }
            set { SetValue(value); }
        }

        public int Length
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }

        public int Damage
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }

        public int Price
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }
    }
}
//model z błędami dla Weapon