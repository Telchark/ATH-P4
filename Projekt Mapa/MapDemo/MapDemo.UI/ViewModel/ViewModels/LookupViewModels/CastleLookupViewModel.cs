using MapDemo.UI.Data;
using MapDemo.UI.Event;
using Prism.Events;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace MapDemo.UI.ViewModel
{
    public class CastleLookupViewModel : ViewModelBase, ICastleLookupViewModel
    {
        private IEventAggregator _eventAggregator;
        private ILookupCastleDataService _castleLookUpService;
        public CastleLookupViewModel(ILookupCastleDataService castleLookUpService, IEventAggregator eventAggregator)
        {
            _castleLookUpService = castleLookUpService;
            Castles = new ObservableCollection<NavigationCastleViewModel>();
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<AfterCastleSavedEvent>().Subscribe(AfterCastleSaved);
        }

        private void AfterCastleSaved(AfterCastleSavedEventArgs obj)
        {
            var lookUpItem = Castles.Single(c => c.CastleId == obj.CastleId);
            lookUpItem.CastleName = obj.CastleName;
        }

        public async Task LoadAsync()
        {
            var lookup = await _castleLookUpService.GetCastleLookupAsync();
            Castles.Clear();
            foreach (var item in lookup)
            {
                Castles.Add(new NavigationCastleViewModel(item.CastleId,item.CastleName));
            }
        }
        public ObservableCollection<NavigationCastleViewModel> Castles { get; set; }
        private NavigationCastleViewModel _selectedCastle;

        public NavigationCastleViewModel SelectedCastle
        {
            get { return _selectedCastle; }
            set
            {
                _selectedCastle = value;
                OnPropertyChanged();
                if (_selectedCastle != null)
                {
                    _eventAggregator.GetEvent<OpenDetailViewEvent>()
                        .Publish(_selectedCastle.CastleId);
                }
            }
        }
    }
}
