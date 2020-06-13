using MapDemo.DataAccess;
using MapDemo.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MapDemo.UI.Data
{
    public class LookupResourceDataService : ILookupResourceDataService
    {
        private Func<MapDemoDbContext> _contextCreator;

        public LookupResourceDataService(Func<MapDemoDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }
        public async Task<IEnumerable<LookupResource>> GetResourceLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Resources.AsNoTracking()
                    .Select(r =>
                    new LookupResource
                    {
                        ResourceId = r.ResourceId,
                        ResourceName = r.Name
                    }).ToListAsync();
            }
        }
    }
}
