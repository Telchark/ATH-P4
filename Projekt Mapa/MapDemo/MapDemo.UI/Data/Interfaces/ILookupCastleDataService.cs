using MapDemo.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MapDemo.UI.Data
{
    public interface ILookupCastleDataService
    {
        Task<IEnumerable<LookupCastle>> GetCastleLookupAsync();
    }
}