using System.Threading.Tasks;

namespace MapDemo.UI.ViewModel
{
    public interface IWeaponDetailViewModel
    {
        Task LoadAsync(int? weaponId);
    }
}