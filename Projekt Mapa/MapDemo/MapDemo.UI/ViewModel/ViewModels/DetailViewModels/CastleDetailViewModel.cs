using MapDemo.Model;
using MapDemo.UI.Data;
using MapDemo.UI.Event;
using Prism.Commands;
using Prism.Events;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MapDemo.UI.ViewModel
{
    public class CastleDetailViewModel : ViewModelBase, ICastleDetailViewModel
    {
        private IEventAggregator _eventAggregator;
        private ICastleDataService _dataService;

        public CastleDetailViewModel(ICastleDataService dataService, IEventAggregator eventAggregator)
        {
            _dataService = dataService;
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<OpenDetailViewEvent>()
                .Subscribe(OnOpenCastleDetailView);
            SaveCommand = new DelegateCommand(OnSaveExecute, OnSaveCanExecute);
        }

        private async void OnSaveExecute()
        {
            await _dataService.SaveAsync(Castle);
            _eventAggregator.GetEvent<AfterCastleSavedEvent>().Publish
                (new AfterCastleSavedEventArgs
                {
                    CastleId = Castle.CastleId,
                    CastleName = Castle.Name
                });
        }

        private bool OnSaveCanExecute()
        {
            //TODO
            return true;
        }

        private async void OnOpenCastleDetailView(int castleId)
        {
            await LoadAsync(castleId);
        }

        public async Task LoadAsync(int castleId)
        {
            Castle = await _dataService.GetByIdAsync(castleId);
        }
        private Castle _castle;

        public Castle Castle
        {
            get { return _castle; }
            private set { _castle = value; OnPropertyChanged(); }
        }

        public ICommand SaveCommand { get; set; }
    }
}
