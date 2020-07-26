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
    public class ArmorDetailViewModel : ViewModelBase, IArmorDetailViewModel
    {
        private IEventAggregator _eventAggregator;
        private IArmorDataService _dataService;

        public ArmorDetailViewModel(IArmorDataService dataService, IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _dataService = dataService;
            SaveCommand = new DelegateCommand(OnSaveExecute, OnSaveCanExecute);
            DeleteCommand = new DelegateCommand(OnDeleteExecute);
        }

        private async void OnDeleteExecute()
        {
            var msgBoxResult = MessageBox.Show($"Do you want to delete {Armor.Name} from the list?", "Delete question", MessageBoxButton.YesNo);
            if (msgBoxResult == MessageBoxResult.Yes)
            {
                _dataService.Remove(Armor.Model);
                await _dataService.SaveAsync();
                _eventAggregator.GetEvent<AfterArmorDeletedEvent>().Publish(Armor.ArmorId);
            }
        }

        private async void OnSaveExecute()
        {
            await _dataService.SaveAsync();
            _eventAggregator.GetEvent<AfterArmorSavedEvent>().Publish
                (new AfterArmorSavedEventArgs
                {
                    ArmorId = Armor.ArmorId,
                    ArmorName = Armor.Name
                });
        }

        private bool OnSaveCanExecute()
        {
            return Armor != null && !Armor.HasErrors && HasChanges;
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


        public async Task LoadAsync(int? armorId)
        {
            var armor = armorId.HasValue ? await _dataService.GetByIdAsync(armorId.Value) : CreateArmor();

            Armor = new ArmorWrapper(armor);
            Armor.PropertyChanged += (s, e) =>
            {
                if (!HasChanges)
                {
                    HasChanges = _dataService.HasChanges();
                }
                if (e.PropertyName == nameof(Armor.HasErrors))
                {
                    ((DelegateCommand)SaveCommand).RaiseCanExecuteChanged();
                }
            };
            ((DelegateCommand)SaveCommand).RaiseCanExecuteChanged();
            if (Armor.ArmorId == 0)
            {
                Armor.Name = "";
            }
        }

        private Armor CreateArmor()
        {
            var armor = new Armor();
            _dataService.Add(armor);
            return armor;
        }

        private ArmorWrapper _armor;

        public ArmorWrapper Armor
        {
            get { return _armor; }
            private set { _armor = value; OnPropertyChanged(); }
        }

        public ICommand SaveCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
    }
}
