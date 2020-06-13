using MapDemo.Model;
using System.Threading.Tasks;

namespace MapDemo.UI.Data
{
    public interface IArmorDataService
    {
        Task<Armor> GetByIdAsync(int armorId);
        Task SaveAsync(Armor armor);
    }
}