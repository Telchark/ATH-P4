using MapDemo.UI.Event;
using Prism.Commands;
using Prism.Events;
using System;
using System.Configuration;
using System.Windows.Input;

namespace MapDemo.UI.ViewModel
{
    public class NavigationCastleViewModel : ViewModelBase
    {
        private string _castleName;
        public NavigationCastleViewModel(int castleId, string castleName, int x, int y, IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            CastleId = castleId;
            CastleName = castleName;
            X = x;
            Y = y;
            OpenCastleDetailViewCommand = new DelegateCommand(OnOpenCastleDetailView);
        }

        private void OnOpenCastleDetailView()
        {
            _eventAggregator.GetEvent<OpenCastleDetailViewEvent>()
                    .Publish(CastleId);

        }

        private IEventAggregator _eventAggregator;

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

        public int X { get; set; }
        public int Y { get; set; }

        public ICommand OpenCastleDetailViewCommand { get; }
    }
}
