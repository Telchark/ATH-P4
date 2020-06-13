using MapDemo.UI.Data;
using MapDemo.UI.Event;
using Prism.Events;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace MapDemo.UI.ViewModel
{
    public class ResourceLookupViewModel : ViewModelBase, IResourceLookupViewModel
    {
        private IEventAggregator _eventAggregator;
        private ILookupResourceDataService _resourceLookUpService;
        public ResourceLookupViewModel(ILookupResourceDataService resourceLookUpService, IEventAggregator eventAggregator)
        {
            _resourceLookUpService = resourceLookUpService;
            Resources = new ObservableCollection<NavigationResourceViewModel>();
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<AfterResourceSavedEvent>().Subscribe(AfterResourceSaved);
        }
        private void AfterResourceSaved(AfterResourceSavedEventArgs obj)
        {
            var lookUpItem = Resources.Single(r => r.ResourceId == obj.ResourceId);
            lookUpItem.ResourceName = obj.ResourceName;
        }
        public async Task LoadAsync()
        {
            var lookup = await _resourceLookUpService.GetResourceLookupAsync();
            Resources.Clear();
            foreach (var item in lookup)
            {
                Resources.Add(new NavigationResourceViewModel(item.ResourceId,item.ResourceName));
            }
        }

        public ObservableCollection<NavigationResourceViewModel> Resources { get; set; }
        private NavigationResourceViewModel _selectedResource;

        public NavigationResourceViewModel SelectedResource
        {
            get { return _selectedResource; }
            set
            {
                _selectedResource = value;
                OnPropertyChanged();
                if (_selectedResource != null)
                {
                    _eventAggregator.GetEvent<OpenDetailViewEvent>()
                        .Publish(_selectedResource.ResourceId);
                }
            }
        }
    }
}
