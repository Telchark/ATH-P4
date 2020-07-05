using MapDemo.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MapDemo.UI.Data
{
    public interface ICastleDataService
    {
        Task<Castle> GetByIdAsync(int castleId);
        Task SaveAsync();
        bool HasChanges();
        void Add(Castle castle);
        void Remove(Castle model);
        Task<List<Weapon>> GetAllWeaponsAsync();
        Task<List<Armor>> GetAllArmorsAsync();
        Task<List<Resource>> GetAllResourcesAsync();
    }
}