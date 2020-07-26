using MapDemo.Model;
using MapDemo.UI.Data;
using MapDemo.UI.Event;
using MapDemo.UI.Wrapper;
using Prism.Commands;
using Prism.Events;
using System;
using System.Threading.Tasks;
using System.Windows;
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
            SaveCommand = new DelegateCommand(OnSaveExecute, OnSaveCanExecute);
            DeleteCommand = new DelegateCommand(OnDeleteExecute);
        }

        private async void OnDeleteExecute()
        {
            var msgBoxResult = MessageBox.Show($"Do you want to delete {Resource.Name} from the list?", "Delete question", MessageBoxButton.YesNo);
            if (msgBoxResult == MessageBoxResult.Yes)
            {
                _dataService.Remove(Resource.Model);
                await _dataService.SaveAsync();
                _eventAggregator.GetEvent<AfterResourceDeletedEvent>().Publish(Resource.ResourceId);
            }
        }

        private async void OnSaveExecute()
        {
            await _dataService.SaveAsync();
            _eventAggregator.GetEvent<AfterResourceSavedEvent>().Publish
                (new AfterResourceSavedEventArgs
                {
                    ResourceId = Resource.ResourceId,
                    ResourceName = Resource.Name
                });
        }

        private bool _hasChanges;

        public bool HasChanges
        {
            get { return _hasChanges; }
            set
            {
                if (_hasChanges != value)
                {
                    _hasChanges = value;
                    OnPropertyChanged();
                    ((DelegateCommand)SaveCommand).RaiseCanExecuteChanged();
                }
            }
        }

        private bool OnSaveCanExecute()
        {
            return Resource != null && !Resource.HasErrors && HasChanges;
        }

        public async Task LoadAsync(int? resourceId)
        {
            var resource = resourceId.HasValue ? await _dataService.GetByIdAsync(resourceId.Value) : CreatResource();

            Resource = new ResourceWrapper(resource);
            Resource.PropertyChanged += (s, e) =>
            {
                if (!HasChanges)
                {
                    HasChanges = _dataService.HasChanges();
                }
                if (e.PropertyName == nameof(Resource.HasErrors))
                {
                    ((DelegateCommand)SaveCommand).RaiseCanExecuteChanged();
                }
            };
            ((DelegateCommand)SaveCommand).RaiseCanExecuteChanged();
            if (Resource.ResourceId == 0)
            {
                Resource.Name = "";
            }
        }

        private Resource CreatResource()
        {
            var resource = new Resource();
            _dataService.Add(resource);
            return resource;
        }

        private ResourceWrapper _resource;
        public ResourceWrapper Resource
        {
            get { return _resource; }
            private set { _resource = value; OnPropertyChanged(); }
        }

        public ICommand SaveCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
    }
}
