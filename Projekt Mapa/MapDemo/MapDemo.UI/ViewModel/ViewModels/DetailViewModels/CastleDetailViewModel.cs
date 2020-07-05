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
            _allWeapons = await _dataService.GetAllWeaponsAsync();
            CreatePicklist();
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

        private void CreatePicklist()
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
        }

    }
}
