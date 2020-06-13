using MapDemo.Model;
using MapDemo.UI.Data;
using MapDemo.UI.Event;
using Prism.Commands;
using Prism.Events;
using System.Threading.Tasks;
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
            _eventAggregator.GetEvent<OpenDetailViewEvent>()
            .Subscribe(OnOpenArmorDetailView);
            SaveCommand = new DelegateCommand(OnSaveExecute, OnSaveCanExecute);
        }

        private async void OnSaveExecute()
        {
            await _dataService.SaveAsync(Armor);
            _eventAggregator.GetEvent<AfterArmorSavedEvent>().Publish
                (new AfterArmorSavedEventArgs
                {
                    ArmorId = Armor.ArmorId,
                    ArmorName = Armor.Name
                });
        }

        private bool OnSaveCanExecute()
        {
            //TODO
            return true;
        }

        private async void OnOpenArmorDetailView(int armorId)
        {
            await LoadAsync(armorId);
        }

        public async Task LoadAsync(int armorId)
        {
            Armor = await _dataService.GetByIdAsync(armorId);
        }
        private Armor _armor;

        public Armor Armor
        {
            get { return _armor; }
            private set { _armor = value; OnPropertyChanged(); }
        }

        public ICommand SaveCommand{ get; set; }
    }
}
