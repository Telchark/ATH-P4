using MapDemo.Model;
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
    }
}