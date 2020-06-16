using MapDemo.DataAccess;
using MapDemo.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MapDemo.UI.Data
{
    public class LookupCastleDataService : ILookupCastleDataService
    {
        private Func<MapDemoDbContext> _contextCreator;

        public LookupCastleDataService(Func<MapDemoDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public async Task<IEnumerable<LookupCastle>> GetCastleLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Castles.AsNoTracking()
                    .Select(c => new LookupCastle
                    {
                        CastleId = c.CastleId,
                        CastleName = c.Name
                    }).ToListAsync();
            }
        }

    }
}
