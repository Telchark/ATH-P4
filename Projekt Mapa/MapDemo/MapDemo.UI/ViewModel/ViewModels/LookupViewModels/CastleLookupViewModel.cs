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
            _eventAggregator.GetEvent<AfterCastleDeletedEvent>().Subscribe(AfterCastleDeleted);
        }

        private void AfterCastleDeleted(int castleId)
        {
            var castle = Castles.SingleOrDefault(c => c.CastleId == castleId);
            if (castle != null)
            {
                Castles.Remove(castle);
            }
        }

        private void AfterCastleSaved(AfterCastleSavedEventArgs obj)
        {
            var lookUpItem = Castles.SingleOrDefault(w => w.CastleId == obj.CastleId);
            if (lookUpItem == null)
            {
                Castles.Add(new NavigationCastleViewModel(obj.CastleId, obj.CastleName, obj.X, obj.Y, _eventAggregator));
            }
            else
            {
                lookUpItem.CastleName = obj.CastleName;
                lookUpItem.X = obj.X;
                lookUpItem.Y = obj.Y;
            }

        }

        public async Task LoadAsync()
        {
            var lookup = await _castleLookUpService.GetCastleLookupAsync();
            Castles.Clear();
            foreach (var item in lookup)
            {
                Castles.Add(new NavigationCastleViewModel(item.CastleId, item.CastleName, item.X, item.Y, _eventAggregator));
            }
        }
        public ObservableCollection<NavigationCastleViewModel> Castles { get; set; }
    }
}
