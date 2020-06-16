using MapDemo.UI.Data;
using MapDemo.UI.Event;
using Prism.Events;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace MapDemo.UI.ViewModel
{
    public class ArmorLookupViewModel : ViewModelBase, IArmorLookupViewModel
    {
        private IEventAggregator _eventAggregator;
        private ILookupArmorDataService _armorLookUpService;
        public ArmorLookupViewModel(ILookupArmorDataService armorLookUpService, IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _armorLookUpService = armorLookUpService;
            Armors = new ObservableCollection<NavigationArmorViewModel>();
            _eventAggregator.GetEvent<AfterArmorSavedEvent>().Subscribe(AfterArmorSaved);
            _eventAggregator.GetEvent<AfterArmorDeletedEvent>().Subscribe(AfterArmorDeleted);
        }

        private void AfterArmorDeleted(int armorID)
        {
            var armor = Armors.SingleOrDefault(a => a.ArmorId == armorID);
            if(armor != null)
            {
                Armors.Remove(armor);
            }
        }

        private void AfterArmorSaved(AfterArmorSavedEventArgs obj)
        {
            var lookUpItem = Armors.SingleOrDefault(w => w.ArmorId == obj.ArmorId);
            if (lookUpItem == null)
            {
                Armors.Add(new NavigationArmorViewModel(obj.ArmorId, obj.ArmorName));
            }
            else
                lookUpItem.ArmorName = obj.ArmorName;
        }

        public async Task LoadAsync()
        {
            var lookup = await _armorLookUpService.GetArmorLookupAsync();
            Armors.Clear();
            foreach (var item in lookup)
            {
                Armors.Add(new NavigationArmorViewModel(item.ArmorId, item.ArmorName));
            }
        }
        public ObservableCollection<NavigationArmorViewModel> Armors { get; set; }
        private NavigationArmorViewModel _selectedArmor;

        public NavigationArmorViewModel SelectedArmor
        {
            get { return _selectedArmor; }
            set
            {
                _selectedArmor = value;
                OnPropertyChanged();
                if (_selectedArmor != null)
                {
                    _eventAggregator.GetEvent<OpenArmorDetailViewEvent>()
                        .Publish(_selectedArmor.ArmorId);
                }
            }
        }
    }
}
