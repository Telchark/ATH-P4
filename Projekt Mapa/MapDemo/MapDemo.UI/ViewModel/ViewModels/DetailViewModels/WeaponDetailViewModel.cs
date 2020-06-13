using MapDemo.Model;
using MapDemo.UI.Data;
using MapDemo.UI.Event;
using Prism.Commands;
using Prism.Events;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MapDemo.UI.ViewModel
{
    public class WeaponDetailViewModel : ViewModelBase, IWeaponDetailViewModel
    {
        private IEventAggregator _eventAggregator;
        private IWeaponDataService _dataService;

        public WeaponDetailViewModel(IWeaponDataService dataService,  IEventAggregator eventAggregator)
        {
            _dataService = dataService;
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<OpenDetailViewEvent>()
                .Subscribe(OnOpenWeaponDetailView);
            SaveCommand = new DelegateCommand(OnSaveExecute, OnSaveCanExecute);
        }

        private async void OnSaveExecute()
        {
            await _dataService.SaveAsync(Weapon);
            _eventAggregator.GetEvent<AfterWeaponSavedEvent>().Publish
                (new AfterWeaponSavedEventArgs
                {
                    WeaponId = Weapon.WeaponId,
                    WeaponName = Weapon.Name
                });
        }

        private bool OnSaveCanExecute()
        {
            //TODO
            return true;
        }

        private async void OnOpenWeaponDetailView(int weaponId)
        {
            await LoadAsync(weaponId);
        }

        public async Task LoadAsync(int weaponId)
        {
            Weapon = await _dataService.GetByIdAsync(weaponId);
        }
        private Weapon _weapon;

        public Weapon Weapon
        {
            get { return _weapon; }
            private set { _weapon = value; OnPropertyChanged(); }
        }

        public ICommand SaveCommand { get; set; }
    }
}
