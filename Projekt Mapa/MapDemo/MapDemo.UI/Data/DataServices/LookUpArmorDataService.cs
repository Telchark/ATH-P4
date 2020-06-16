using MapDemo.DataAccess;
using MapDemo.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MapDemo.UI.Data
{
    public class LookupArmorDataService : ILookupArmorDataService
    {
        private Func<MapDemoDbContext> _contextCreator;

        public LookupArmorDataService(Func<MapDemoDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }
        public async Task<IEnumerable<LookupArmor>> GetArmorLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Armors.AsNoTracking()
                    .Select(a =>
                    new LookupArmor
                    {
                        ArmorId = a.ArmorId,
                        ArmorName = a.Name
                    }).ToListAsync();
            }
        }
    }
}
