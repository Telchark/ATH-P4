using MapDemo.UI.Event;
using Prism.Commands;
using Prism.Events;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MapDemo.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(IWeaponLookupViewModel weaponLookupViewModel, Func<IWeaponDetailViewModel> weaponDetailViewModelCreator,
            IArmorLookupViewModel armorLookupViewModel, Func<IArmorDetailViewModel> armorDetailViewModelCreator,
            IResourceLookupViewModel resourceLookupViewModel, Func<IResourceDetailViewModel> resourceDetailViewModelCreator,
            ICastleLookupViewModel castleLookupViewModel, Func<ICastleDetailViewModel> castleDetailViewModelCreator,
            IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            WeaponLookupViewModel = weaponLookupViewModel;
            _weaponDetailViewModelCreator = weaponDetailViewModelCreator;
            _eventAggregator.GetEvent<OpenWeaponDetailViewEvent>().Subscribe(OnOpenWeaponDetailView);
            CreateNewWeaponCommand = new DelegateCommand(AddNewWaepon);

            ArmorLookupViewModel = armorLookupViewModel;
            _armorDetailViewModelCreator = armorDetailViewModelCreator;
            _eventAggregator.GetEvent<OpenArmorDetailViewEvent>().Subscribe(OnOpenArmorDetailView);
            CreateNewArmorCommand = new DelegateCommand(AddNewArmor);

            ResourceLookupViewModel = resourceLookupViewModel;
            _resourceDetailViewModelCreator = resourceDetailViewModelCreator;
            _eventAggregator.GetEvent<OpenResourceDetailViewEvent>().Subscribe(OnOpenResourceDetailView);
            CreateNewResourceCommand = new DelegateCommand(AddNewResource);

            CastleLookupViewModel = castleLookupViewModel;
            _castleDetailViewModelCreator = castleDetailViewModelCreator;
            _eventAggregator.GetEvent<OpenCastleDetailViewEvent>().Subscribe(OnOpenCastleDetailView);
            CreateNewCastleCommand = new DelegateCommand(AddNewCastle);
        }

        public async Task LoadAsync()
        {
            await WeaponLookupViewModel.LoadAsync();
            await ArmorLookupViewModel.LoadAsync();
            await ResourceLookupViewModel.LoadAsync();
            await CastleLookupViewModel.LoadAsync();
        }
        public IWeaponLookupViewModel WeaponLookupViewModel { get; }

        private Func<IWeaponDetailViewModel> _weaponDetailViewModelCreator;
        private IWeaponDetailViewModel _weaponDetailViewModel;
        public IWeaponDetailViewModel WeaponDetailViewModel
        {
            get { return _weaponDetailViewModel; }
            set { _weaponDetailViewModel = value; OnPropertyChanged(); }
        }

        private async void OnOpenWeaponDetailView(int? weaponId)
        {
            WeaponDetailViewModel = _weaponDetailViewModelCreator();
            await WeaponDetailViewModel.LoadAsync(weaponId);
        }

        public IArmorLookupViewModel ArmorLookupViewModel { get; }
        private Func<IArmorDetailViewModel> _armorDetailViewModelCreator;
        private IArmorDetailViewModel _armorDetailViewModel;
        public IArmorDetailViewModel ArmorDetailViewModel
        {
            get { return _armorDetailViewModel; }
            set { _armorDetailViewModel = value; OnPropertyChanged(); }
        }
        private async void OnOpenArmorDetailView(int? armorId)
        {
            ArmorDetailViewModel = _armorDetailViewModelCreator();
            await ArmorDetailViewModel.LoadAsync(armorId);
        }

        public IResourceLookupViewModel ResourceLookupViewModel { get; }
        private Func<IResourceDetailViewModel> _resourceDetailViewModelCreator;
        private IResourceDetailViewModel _resourceDetailViewModel;

        public IResourceDetailViewModel ResourceDetailViewModel
        {
            get { return _resourceDetailViewModel; }
            set { _resourceDetailViewModel = value; OnPropertyChanged(); }
        }
        private async void OnOpenResourceDetailView(int? resourceId)
        {
            ResourceDetailViewModel = _resourceDetailViewModelCreator();
            await ResourceDetailViewModel.LoadAsync(resourceId);
        }


        public ICastleLookupViewModel CastleLookupViewModel { get; }
        private Func<ICastleDetailViewModel> _castleDetailViewModelCreator;
        private ICastleDetailViewModel _castleDetailViewModel;

        public ICastleDetailViewModel CastleDetailViewModel
        {
            get { return _castleDetailViewModel; }
            set { _castleDetailViewModel = value; OnPropertyChanged(); }
        }
        private async void OnOpenCastleDetailView(int? castleId)
        {
            CastleDetailViewModel = _castleDetailViewModelCreator();
            await CastleDetailViewModel.LoadAsync(castleId);
        }

        public ICommand CreateNewWeaponCommand { get; set; }
        private void AddNewWaepon()
        {
            OnOpenWeaponDetailView(null);
        }
        public ICommand CreateNewArmorCommand { get; set; }
        private void AddNewArmor()
        {
            OnOpenArmorDetailView(null);
        }
        public ICommand CreateNewResourceCommand { get; set; }
        private void AddNewResource()
        {
            OnOpenResourceDetailView(null);
        }
        public ICommand CreateNewCastleCommand { get; set; }
        private void AddNewCastle()
        {
            OnOpenCastleDetailView(null);
        }
        private IEventAggregator _eventAggregator;
    }
}
