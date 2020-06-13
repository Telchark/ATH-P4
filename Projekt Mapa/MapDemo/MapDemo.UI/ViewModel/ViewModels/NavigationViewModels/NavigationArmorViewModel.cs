namespace MapDemo.UI.ViewModel
{
    public class NavigationArmorViewModel : ViewModelBase
    {
        private string _armorName;

        public NavigationArmorViewModel(int armorId, string armorName)
        {
            ArmorId = armorId;
            ArmorName = armorName;
        }

        public int ArmorId { get; }

        public string ArmorName
        {
            get { return _armorName; }
            set
            {
                _armorName = value;
                OnPropertyChanged();
            }
        }
    }
}
