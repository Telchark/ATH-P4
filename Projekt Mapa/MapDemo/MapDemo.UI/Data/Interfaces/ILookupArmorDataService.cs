using MapDemo.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MapDemo.UI.Data
{
    public interface ILookupArmorDataService
    {
        Task<IEnumerable<LookupArmor>> GetArmorLookupAsync();
    }
}