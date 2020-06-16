using MapDemo.Model;
using System.Threading.Tasks;

namespace MapDemo.UI.Data
{
    public interface IArmorDataService
    {
        Task<Armor> GetByIdAsync(int armorId);
        Task SaveAsync();
        bool HasChanges();
        void Add(Armor armor);
        void Remove(Armor armor);
    }
}