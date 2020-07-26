using MapDemo.Model;
using MapDemo.UI.Data;
using MapDemo.UI.Event;
using MapDemo.UI.Wrapper;
using Prism.Commands;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

namespace MapDemo.UI.ViewModel
{
    public class CastleDetailViewModel : ViewModelBase, ICastleDetailViewModel
    {
        private IEventAggregator _eventAggregator;
        private ICastleDataService _dataService;

        private Weapon _selectedAvailableWeapon;
        private Weapon _selectedAddedWeapon;
        private List<Weapon> _allWeapons;

        private Armor _selectedAvailableArmor;
        private Armor _selectedAddedArmor;
        private List<Armor> _allArmors;

        private Resource _selectedAvailableResource;
        private Resource _selectedAddedResource;
        private List<Resource> _allResources;

        public CastleDetailViewModel(ICastleDataService dataService, IEventAggregator eventAggregator)
        {

            _dataService = dataService;
            _eventAggregator = eventAggregator;

            SaveCommand = new DelegateCommand(OnSaveExecute, OnSaveCanExecute);
            DeleteCommand = new DelegateCommand(OnDeleteExecute);
            AddedWeapons = new ObservableCollection<Weapon>();
            AvailableWeapons = new ObservableCollection<Weapon>();
            AddWeaponCommand = new DelegateCommand(OnAddWeaponExecute, OnAddWeaponCanExecute);
            RemoveWeaponCommand = new DelegateCommand(OnRemoveWeaponExecute, OnRemoveWeaponCanExecute);

            AddedArmors = new ObservableCollection<Armor>();
            AvailableArmors = new ObservableCollection<Armor>();
            AddArmorCommand = new DelegateCommand(OnAddArmorExecute, OnAddArmorCanExecute);
            RemoveArmorCommand = new DelegateCommand(OnRemoveArmorExecute, OnRemoveArmorCanExecute);

            AddedResources = new ObservableCollection<Resource>();
            AvailableResources = new ObservableCollection<Resource>();
            AddResourceCommand = new DelegateCommand(OnAddResourceExecute, OnAddResourceCanExecute);
            RemoveResourceCommand = new DelegateCommand(OnRemoveResourceExecute, OnRemoveResourceCanExecute);
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
                    CastleName = Castle.Name,
                    X = Castle.X,
                    Y = Castle.Y
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
            if (Castle.CastleId == 0)
            {
                Castle.Name = "";
            }
            _allWeapons = await _dataService.GetAllWeaponsAsync();
            _allArmors = await _dataService.GetAllArmorsAsync();
            _allResources = await _dataService.GetAllResourcesAsync();
            CreatePicklists();
        }

        private void CreatePicklists()
        {
            var castleWeaponId = Castle.Model.Weapons.Select(w => w.WeaponId).ToList();
            var addedWeapons = _allWeapons.Where(w => castleWeaponId.Contains(w.WeaponId));
            var availableWeapons = _allWeapons.Except(addedWeapons);
            AddedWeapons.Clear();
            AvailableWeapons.Clear();
            foreach (var addedWeapon in addedWeapons)
            {
                AddedWeapons.Add(addedWeapon);
            }
            foreach (var availableWeapon in availableWeapons)
            {
                AvailableWeapons.Add(availableWeapon);
            }

            var castleArmorId = Castle.Model.Armors.Select(w => w.ArmorId).ToList();
            var addedArmors = _allArmors.Where(w => castleArmorId.Contains(w.ArmorId));
            var availableArmors = _allArmors.Except(addedArmors);
            AddedArmors.Clear();
            AvailableArmors.Clear();
            foreach (var addedArmor in addedArmors)
            {
                AddedArmors.Add(addedArmor);
            }
            foreach (var availableArmor in availableArmors)
            {
                AvailableArmors.Add(availableArmor);
            }

            var castleResourceId = Castle.Model.Resources.Select(w => w.ResourceId).ToList();
            var addedResources = _allResources.Where(w => castleResourceId.Contains(w.ResourceId));
            var availableResources = _allResources.Except(addedResources);
            AddedResources.Clear();
            AvailableResources.Clear();
            foreach (var addedResource in addedResources)
            {
                AddedResources.Add(addedResource);
            }
            foreach (var availableResource in availableResources)
            {
                AvailableResources.Add(availableResource);
            }
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

        public ICommand AddWeaponCommand { get; }
        public ICommand RemoveWeaponCommand { get; }

        public ObservableCollection<Weapon> AddedWeapons { get; }

        public ObservableCollection<Weapon> AvailableWeapons { get; }

        public Weapon SelectedAvailableWeapon
        {
            get { return _selectedAvailableWeapon; }
            set
            {
                _selectedAvailableWeapon = value;
                OnPropertyChanged();
                ((DelegateCommand)AddWeaponCommand).RaiseCanExecuteChanged();
            }
        }

        public Weapon SelectedAddedWeapon
        {
            get { return _selectedAddedWeapon; }
            set
            {
                _selectedAddedWeapon = value;
                OnPropertyChanged();
                ((DelegateCommand)RemoveWeaponCommand).RaiseCanExecuteChanged();
            }
        }

        private void OnRemoveWeaponExecute()
        {
            var weaponToRemove = SelectedAddedWeapon;

            Castle.Model.Weapons.Remove(weaponToRemove);
            AddedWeapons.Remove(weaponToRemove);
            AvailableWeapons.Add(weaponToRemove);
            HasChanges = _dataService.HasChanges();
            ((DelegateCommand)SaveCommand).RaiseCanExecuteChanged();
        }

        private bool OnRemoveWeaponCanExecute()
        {
            return SelectedAddedWeapon != null;
        }

        private bool OnAddWeaponCanExecute()
        {
            return SelectedAvailableWeapon != null;
        }

        private void OnAddWeaponExecute()
        {
            var weaponToAdd = SelectedAvailableWeapon;

            Castle.Model.Weapons.Add(weaponToAdd);
            AddedWeapons.Add(weaponToAdd);
            AvailableWeapons.Remove(weaponToAdd);
            HasChanges = _dataService.HasChanges();
            ((DelegateCommand)SaveCommand).RaiseCanExecuteChanged();
        }


        public ICommand AddArmorCommand { get; }
        public ICommand RemoveArmorCommand { get; }

        public ObservableCollection<Armor> AddedArmors { get; }

        public ObservableCollection<Armor> AvailableArmors { get; }

        public Armor SelectedAvailableArmor
        {
            get { return _selectedAvailableArmor; }
            set
            {
                _selectedAvailableArmor = value;
                OnPropertyChanged();
                ((DelegateCommand)AddArmorCommand).RaiseCanExecuteChanged();
            }
        }

        public Armor SelectedAddedArmor
        {
            get { return _selectedAddedArmor; }
            set
            {
                _selectedAddedArmor = value;
                OnPropertyChanged();
                ((DelegateCommand)RemoveArmorCommand).RaiseCanExecuteChanged();
            }
        }

        private void OnRemoveArmorExecute()
        {
            var armorToRemove = SelectedAddedArmor;

            Castle.Model.Armors.Remove(armorToRemove);
            AddedArmors.Remove(armorToRemove);
            AvailableArmors.Add(armorToRemove);
            HasChanges = _dataService.HasChanges();
            ((DelegateCommand)SaveCommand).RaiseCanExecuteChanged();
        }

        private bool OnRemoveArmorCanExecute()
        {
            return SelectedAddedArmor != null;
        }

        private bool OnAddArmorCanExecute()
        {
            return SelectedAvailableArmor != null;
        }

        private void OnAddArmorExecute()
        {
            var armorToAdd = SelectedAvailableArmor;

            Castle.Model.Armors.Add(armorToAdd);
            AddedArmors.Add(armorToAdd);
            AvailableArmors.Remove(armorToAdd);
            HasChanges = _dataService.HasChanges();
            ((DelegateCommand)SaveCommand).RaiseCanExecuteChanged();
        }



        public ICommand AddResourceCommand { get; }
        public ICommand RemoveResourceCommand { get; }

        public ObservableCollection<Resource> AddedResources { get; }

        public ObservableCollection<Resource> AvailableResources { get; }

        public Resource SelectedAvailableResource
        {
            get { return _selectedAvailableResource; }
            set
            {
                _selectedAvailableResource = value;
                OnPropertyChanged();
                ((DelegateCommand)AddResourceCommand).RaiseCanExecuteChanged();
            }
        }

        public Resource SelectedAddedResource
        {
            get { return _selectedAddedResource; }
            set
            {
                _selectedAddedResource = value;
                OnPropertyChanged();
                ((DelegateCommand)RemoveResourceCommand).RaiseCanExecuteChanged();
            }
        }

        private void OnRemoveResourceExecute()
        {
            var resourceToRemove = SelectedAddedResource;

            Castle.Model.Resources.Remove(resourceToRemove);
            AddedResources.Remove(resourceToRemove);
            AvailableResources.Add(resourceToRemove);
            HasChanges = _dataService.HasChanges();
            ((DelegateCommand)SaveCommand).RaiseCanExecuteChanged();
        }

        private bool OnRemoveResourceCanExecute()
        {
            return SelectedAddedResource != null;
        }

        private bool OnAddResourceCanExecute()
        {
            return SelectedAvailableResource != null;
        }

        private void OnAddResourceExecute()
        {
            var resourceToAdd = SelectedAvailableResource;

            Castle.Model.Resources.Add(resourceToAdd);
            AddedResources.Add(resourceToAdd);
            AvailableResources.Remove(resourceToAdd);
            HasChanges = _dataService.HasChanges();
            ((DelegateCommand)SaveCommand).RaiseCanExecuteChanged();
        }

    }
}
