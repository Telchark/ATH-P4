using MapDemo.Model;
using MapDemo.UI.Data;
using MapDemo.UI.Event;
using Prism.Commands;
using Prism.Events;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MapDemo.UI.ViewModel
{
    public class ResourceDetailViewModel : ViewModelBase, IResourceDetailViewModel
    {
        private IEventAggregator _eventAggregator;
        private IResourceDataService _dataService;
        public ResourceDetailViewModel(IResourceDataService dataService, IEventAggregator eventAggregator)
        {
            _dataService = dataService;
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<OpenDetailViewEvent>()
               .Subscribe(OnOpenResourceDetailView);
            SaveCommand = new DelegateCommand(OnSaveExecute, OnSaveCanExecute);
        }

        private async void OnSaveExecute()
        {
            await _dataService.SaveAsync(Resource);
            _eventAggregator.GetEvent<AfterResourceSavedEvent>().Publish
                (new AfterResourceSavedEventArgs
                {
                    ResourceId = Resource.ResourceId,
                    ResourceName = Resource.Name
                });
        }

        private bool OnSaveCanExecute()
        {
            //TODO
            return true;
        }

        private async void OnOpenResourceDetailView(int resourceId)
        {
            await LoadAsync(resourceId);
        }

        public async Task LoadAsync(int resourceId)
        {
            Resource = await _dataService.GetByIdAsync(resourceId);
        }
        private Resource _resource;
        public Resource Resource
        {
            get { return _resource; }
            private set { _resource = value; OnPropertyChanged(); }
        }

        public ICommand SaveCommand { get; set; }
    }
}
