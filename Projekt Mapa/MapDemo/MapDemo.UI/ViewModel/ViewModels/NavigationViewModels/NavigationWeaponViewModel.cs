namespace MapDemo.UI.ViewModel
{
    public class NavigationWeaponViewModel : ViewModelBase
    {
        private string _weaponName;
        public NavigationWeaponViewModel(int weaponId, string weaponName)
        {
            WeaponId = weaponId;
            WeaponName = weaponName;
        }

        public int WeaponId { get; }

        public string WeaponName
        {
            get { return _weaponName; }
            set
            {
                _weaponName = value;
                OnPropertyChanged();
            }
        }
    }
}
