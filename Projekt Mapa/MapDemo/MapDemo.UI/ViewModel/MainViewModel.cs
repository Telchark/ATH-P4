using MapDemo.Model;
using MapDemo.UI.Data;
using System.Collections.ObjectModel;
using System.Windows.Navigation;

namespace MapDemo.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private IWeaponDataService _weaponDataService;
        private Weapon _selectedWeapon;

        public MainViewModel(IWeaponDataService weaponDataService)
        {
            Weapons = new ObservableCollection<Weapon>();
            _weaponDataService = weaponDataService;
        }

        public void Load()
        {
            var weapons = _weaponDataService.GetAll();
            Weapons.Clear();
            foreach(var weapon in weapons)
            {
                Weapons.Add(weapon);
            }
        }

        public ObservableCollection<Weapon> Weapons { get; set; }



        public Weapon SelectedWeapon
        {
            get { return _selectedWeapon; }
            set { _selectedWeapon = value;
                OnPropertyChanged(); }
        }


    }
}
