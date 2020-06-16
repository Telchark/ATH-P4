using MapDemo.DataAccess;
using MapDemo.Model;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace MapDemo.UI.Data
{
    public class ResourceDataService : IResourceDataService
    {
        MapDemoDbContext _context;

        public ResourceDataService(MapDemoDbContext context)
        {
            _context = context;
        }

        public void Add(Resource resource)
        {
            _context.Resources.Add(resource);
        }

        public async Task<Resource> GetByIdAsync(int resourceId)
        {
                return await _context.Resources.SingleAsync(r => r.ResourceId == resourceId);
        }
        public bool HasChanges()
        {
            return _context.ChangeTracker.HasChanges();
        }

        public void Remove(Resource model)
        {
            _context.Resources.Remove(model);
        }

        public async Task SaveAsync()
        {
                await _context.SaveChangesAsync();
        }
    }
}
