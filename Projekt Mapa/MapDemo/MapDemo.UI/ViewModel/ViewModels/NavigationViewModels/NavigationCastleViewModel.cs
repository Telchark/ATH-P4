namespace MapDemo.UI.ViewModel
{
    public class NavigationCastleViewModel : ViewModelBase
    {
        private string _castleName;
        public NavigationCastleViewModel(int castleId, string castleName)
        {
            CastleId = castleId;
            CastleName = castleName;
        }

        public int CastleId { get; }

        public string CastleName
        {
            get { return _castleName; }
            set
            {
                _castleName = value;
                OnPropertyChanged();
            }
        }
    }
}
