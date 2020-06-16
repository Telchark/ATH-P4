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
    public class WeaponDetailViewModel : ViewModelBase, IWeaponDetailViewModel
    {
        private IEventAggregator _eventAggregator;
        private IWeaponDataService _dataService;

        public WeaponDetailViewModel(IWeaponDataService dataService, IEventAggregator eventAggregator)
        {
            _dataService = dataService;
            _eventAggregator = eventAggregator;
            SaveCommand = new DelegateCommand(OnSaveExecute, OnSaveCanExecute);
            DeleteCommand = new DelegateCommand(OnDeleteExecute);
        }

        private async void OnDeleteExecute()
        {
            var msgBoxResult = MessageBox.Show($"Do you want to delete {Weapon.Name} from the list?", "Delete question", MessageBoxButton.YesNo);
            if(msgBoxResult == MessageBoxResult.Yes) { 
            _dataService.Remove(Weapon.Model);
            await _dataService.SaveAsync();
            _eventAggregator.GetEvent<AfterWeaponDeletedEvent>().Publish(Weapon.WeaponId);
            }
        }

        private async void OnSaveExecute()
        {
            await _dataService.SaveAsync();
            _eventAggregator.GetEvent<AfterWeaponSavedEvent>().Publish
                (new AfterWeaponSavedEventArgs
                {
                    WeaponId = Weapon.WeaponId,
                    WeaponName = Weapon.Name
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
            return Weapon != null && !Weapon.HasErrors && HasChanges;
        }

        public async Task LoadAsync(int? weaponId)
        {
            var weapon = weaponId.HasValue ? await _dataService.GetByIdAsync(weaponId.Value) : CreateWeapon();

            Weapon = new WeaponWrapper(weapon);
            Weapon.PropertyChanged += (s, e) =>
            {
                if (!HasChanges)
                {
                    HasChanges = _dataService.HasChanges();
                }
                if (e.PropertyName == nameof(Weapon.HasErrors))
                {
                    ((DelegateCommand)SaveCommand).RaiseCanExecuteChanged();
                }
            };
            ((DelegateCommand)SaveCommand).RaiseCanExecuteChanged();
        }

        private Weapon CreateWeapon()
        {
            var weapon = new Weapon();
            _dataService.Add(weapon);
            return weapon;
        }

        private WeaponWrapper _weapon;

        public WeaponWrapper Weapon
        {
            get { return _weapon; }
            private set { _weapon = value; OnPropertyChanged(); }
        }

        public ICommand SaveCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
    }
}
