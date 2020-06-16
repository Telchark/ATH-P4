using MapDemo.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MapDemo.UI.Data
{
    public interface ILookupResourceDataService
    {
        Task<IEnumerable<LookupResource>> GetResourceLookupAsync();
    }
}