using MapDemo.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MapDemo.UI.Data
{
    public interface ILookupWeaponDataService
    {
        Task<IEnumerable<LookupWeapon>> GetWeaponLookupAsync();
    }
}