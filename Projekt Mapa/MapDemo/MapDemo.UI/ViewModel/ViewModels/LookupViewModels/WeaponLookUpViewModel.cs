using MapDemo.UI.Data;
using MapDemo.UI.Event;
using Prism.Events;
using System;
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
            _eventAggregator.GetEvent<AfterWeaponDeletedEvent>().Subscribe(AfterWeaponDeleted);
        }

        private void AfterWeaponDeleted(int weaponId)
        {
            var weapon = Weapons.SingleOrDefault(w => w.WeaponId == weaponId);
            if(weapon != null)
            {
                Weapons.Remove(weapon);
            }
        }

        private void AfterWeaponSaved(AfterWeaponSavedEventArgs obj)
        {
            var lookUpItem = Weapons.SingleOrDefault(w => w.WeaponId == obj.WeaponId);
            if(lookUpItem == null)
            {
                Weapons.Add(new NavigationWeaponViewModel(obj.WeaponId, obj.WeaponName));
            }
            else
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
                    _eventAggregator.GetEvent<OpenWeaponDetailViewEvent>()
                        .Publish(_selectedWeapon.WeaponId);
                }
            }
        }

    }
}
//tworzymy observablecollection dla LookupWeapon na jej podstawie są tworzone elemnty w panelu nawigacyjnym
//bindujemy SelectedWeapon na SelectedItem z listy i podpinamy do tego Event OpenDetailViewEvent który jako parametr wysyła id aktualnie wybranego elementu
//event AfterWeaponSavedEvent wysyła jako argumenty id i nazwe elementu które potem są aktualizowane na liście przez metodę AfterWeaponSaved()