using MapDemo.UI.Data;
using MapDemo.UI.Event;
using Prism.Events;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace MapDemo.UI.ViewModel
{
    public class WeaponLookupViewModel : ViewModelBase, IWeaponLookupViewModel
    {
        private IEventAggregator _eventAggregator;
        private ILookupWeaponDataService _weaponLookUpService;
        public WeaponLookupViewModel(ILookupWeaponDataService weaponLookUpService, IEventAggregator eventAggregator)
        {
            _weaponLookUpService = weaponLookUpService;
            Weapons = new ObservableCollection<NavigationWeaponViewModel>();
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<AfterWeaponSavedEvent>().Subscribe(AfterWeaponSaved);
        }

        private void AfterWeaponSaved(AfterWeaponSavedEventArgs obj)
        {
            var lookUpItem = Weapons.Single(w => w.WeaponId == obj.WeaponId);
            lookUpItem.WeaponName = obj.WeaponName;
        }

        public async Task LoadAsync()
        {
            var lookup = await _weaponLookUpService.GetWeaponLookupAsync();
            Weapons.Clear();
            foreach (var item in lookup)
            {
                Weapons.Add(new NavigationWeaponViewModel(item.WeaponId,item.WeaponName));
            }
        }
        public ObservableCollection<NavigationWeaponViewModel> Weapons { get; set; }
        private NavigationWeaponViewModel _selectedWeapon;

        public NavigationWeaponViewModel SelectedWeapon
        {
            get { return _selectedWeapon; }
            set { _selectedWeapon = value; 
                OnPropertyChanged();
            if(_selectedWeapon!=null)
                {
                    _eventAggregator.GetEvent<OpenDetailViewEvent>()
                        .Publish(_selectedWeapon.WeaponId);
                }
            }
        }

    }
}
