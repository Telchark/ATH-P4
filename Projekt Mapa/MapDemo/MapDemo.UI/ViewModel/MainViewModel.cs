using System.Threading.Tasks;

namespace MapDemo.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(IWeaponLookupViewModel weaponLookupViewModel, IWeaponDetailViewModel weaponDetailViewModel,
            IArmorLookupViewModel armorLookupViewModel, IArmorDetailViewModel armorDetailViewModel,
            IResourceLookupViewModel resourceLookupViewModel, IResourceDetailViewModel resourceDetailViewModel,
            ICastleLookupViewModel castleLookupViewModel, ICastleDetailViewModel castleDetailViewModel)
        {
            WeaponLookupViewModel = weaponLookupViewModel;
            WeaponDetailViewModel = weaponDetailViewModel;

            ArmorLookupViewModel = armorLookupViewModel;
            ArmorDetailViewModel = armorDetailViewModel;

            ResourceLookupViewModel = resourceLookupViewModel;
            ResourceDetailViewModel = resourceDetailViewModel;

            CastleLookupViewModel = castleLookupViewModel;
            CastleDetailViewModel = castleDetailViewModel;
        }
        public async Task LoadAsync()
        {
            await WeaponLookupViewModel.LoadAsync();
            await ArmorLookupViewModel.LoadAsync();
            await ResourceLookupViewModel.LoadAsync();
            await CastleLookupViewModel.LoadAsync();
        }
        public IWeaponLookupViewModel WeaponLookupViewModel { get; }
        public IWeaponDetailViewModel WeaponDetailViewModel { get; }

        public IArmorLookupViewModel ArmorLookupViewModel { get; }
        public IArmorDetailViewModel ArmorDetailViewModel { get; }

        public IResourceLookupViewModel ResourceLookupViewModel { get; }
        public IResourceDetailViewModel ResourceDetailViewModel { get; }

        public ICastleLookupViewModel CastleLookupViewModel { get; }
        public ICastleDetailViewModel CastleDetailViewModel { get; }

    }
}
