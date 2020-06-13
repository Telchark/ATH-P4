using MapDemo.DataAccess;
using MapDemo.Model;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace MapDemo.UI.Data
{
    public class ResourceDataService : IResourceDataService
    {
        private Func<MapDemoDbContext> _contextCreator;

        public ResourceDataService(Func<MapDemoDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }
        public async Task<Resource> GetByIdAsync(int resourceId)
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Resources.AsNoTracking().SingleAsync(r => r.ResourceId == resourceId);
            }
        }

        public async Task SaveAsync(Resource resource)
        {
            using (var ctx = _contextCreator())
            {
                ctx.Resources.Attach(resource);
                ctx.Entry(resource).State = EntityState.Modified;
                await ctx.SaveChangesAsync();
            }
        }
    }
}
