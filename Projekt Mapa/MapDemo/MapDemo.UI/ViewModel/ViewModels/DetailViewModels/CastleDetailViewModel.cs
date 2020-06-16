using MapDemo.Model;
using MapDemo.UI.Data;
using MapDemo.UI.Event;
using MapDemo.UI.Wrapper;
using Prism.Commands;
using Prism.Events;
using System;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Threading.Tasks;
using System.Windows;
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

            SaveCommand = new DelegateCommand(OnSaveExecute, OnSaveCanExecute);
            DeleteCommand = new DelegateCommand(OnDeleteExecute);
        }

        private async void OnDeleteExecute()
        {
            var msgBoxResult = MessageBox.Show($"Do you want to delete {Castle.Name} from the list?", "Delete question", MessageBoxButton.YesNo);
            if (msgBoxResult == MessageBoxResult.Yes)
            {
                _dataService.Remove(Castle.Model);
                await _dataService.SaveAsync();
                _eventAggregator.GetEvent<AfterCastleDeletedEvent>().Publish(Castle.CastleId);
            }

        }

        private async void OnSaveExecute()
        {
            await _dataService.SaveAsync();
            _eventAggregator.GetEvent<AfterCastleSavedEvent>().Publish
                (new AfterCastleSavedEventArgs
                {
                    CastleId = Castle.CastleId,
                    CastleName = Castle.Name
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
            return Castle != null && !Castle.HasErrors && HasChanges;
        }

        public async Task LoadAsync(int? castleId)
        {
            var castle = castleId.HasValue ? await _dataService.GetByIdAsync(castleId.Value) : CreateCastle();

            Castle = new CastleWrapper(castle);
            Castle.PropertyChanged += (s, e) => // new EventHandler(delegate (Object s, EventArgs e) <===> += (s,e) => 
            {
                if (!HasChanges)
                {
                    HasChanges = _dataService.HasChanges();
                }
                if (e.PropertyName == nameof(Castle.HasErrors))
                {
                    ((DelegateCommand)SaveCommand).RaiseCanExecuteChanged();
                }
            };
            ((DelegateCommand)SaveCommand).RaiseCanExecuteChanged();
        }

        private Castle CreateCastle()
        {
            var castle = new Castle();
            _dataService.Add(castle);
            return castle;
        }

        private CastleWrapper _castle;

        public CastleWrapper Castle
        {
            get { return _castle; }
            private set { _castle = value; OnPropertyChanged(); }
        }

        public ICommand SaveCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
    }
}
