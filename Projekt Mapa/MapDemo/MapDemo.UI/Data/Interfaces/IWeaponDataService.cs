using MapDemo.Model;
using System.Threading.Tasks;

namespace MapDemo.UI.Data
{
    public interface IWeaponDataService
    {
        Task<Weapon> GetByIdAsync(int weaponId);
        Task SaveAsync(Weapon weapon);
    }
}