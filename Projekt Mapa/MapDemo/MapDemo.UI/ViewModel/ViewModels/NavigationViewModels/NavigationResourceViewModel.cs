namespace MapDemo.UI.ViewModel
{
    public class NavigationResourceViewModel : ViewModelBase
    {
        private string _resourceName;

        public NavigationResourceViewModel(int resourceId, string resourceName)
        {
            ResourceId = resourceId;
            ResourceName = resourceName;
        }

        public int ResourceId { get; }

        public string ResourceName
        {
            get { return _resourceName; }
            set
            {
                _resourceName = value;
                OnPropertyChanged();
            }
        }
    }
}
