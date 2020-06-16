using MapDemo.UI.Data;
using MapDemo.UI.Event;
using Prism.Events;
using System;
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
            _eventAggregator.GetEvent<AfterResourceDeletedEvent>().Subscribe(AfterResourceDeleted);
        }

        private void AfterResourceDeleted(int resourceId)
        {
            var resource = Resources.SingleOrDefault(r => r.ResourceId == resourceId);
            if(resource != null)
            {
                Resources.Remove(resource);
            }
        }

        private void AfterResourceSaved(AfterResourceSavedEventArgs obj)
        {
            var lookUpItem = Resources.SingleOrDefault(w => w.ResourceId == obj.ResourceId);
            if (lookUpItem == null)
            {
                Resources.Add(new NavigationResourceViewModel(obj.ResourceId, obj.ResourceName));
            }
            else
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
                    _eventAggregator.GetEvent<OpenResourceDetailViewEvent>()
                        .Publish(_selectedResource.ResourceId);
                }
            }
        }
    }
}
