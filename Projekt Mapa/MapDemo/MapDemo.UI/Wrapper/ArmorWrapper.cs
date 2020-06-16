using MapDemo.Model;
using static MapDemo.Model.Armor;

namespace MapDemo.UI.Wrapper
{
    public class ArmorWrapper : ModelWrapper<Armor>
    {
        public ArmorWrapper(Armor model) : base(model)
        {
        }

        public int ArmorId { get { return Model.ArmorId; } }

        public string Name
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public ArmorType Type
        {
            get { return GetValue<ArmorType>(); }
            set { SetValue(value); }
        }

        public double Weight
        {
            get { return GetValue<double>(); }
            set { SetValue(value); }
        }

        public int ArmorValue
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
