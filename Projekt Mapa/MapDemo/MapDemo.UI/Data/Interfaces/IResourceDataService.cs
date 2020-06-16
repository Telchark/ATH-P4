using MapDemo.Model;
using System.Threading.Tasks;

namespace MapDemo.UI.Data
{
    public interface IResourceDataService
    {
        Task<Resource> GetByIdAsync(int resourceId);
        Task SaveAsync();
        bool HasChanges();
        void Add(Resource resource);
        void Remove(Resource model);
    }
}