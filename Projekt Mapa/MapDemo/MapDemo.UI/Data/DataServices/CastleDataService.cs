using MapDemo.DataAccess;
using MapDemo.Model;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace MapDemo.UI.Data
{
    public class CastleDataService : ICastleDataService
    {
        private Func<MapDemoDbContext> _contextCreator;

        public CastleDataService(Func<MapDemoDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }
        public async Task<Castle> GetByIdAsync(int castleId)
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Castles.AsNoTracking().SingleAsync(c => c.CastleId == castleId);
            }
        }

        public async Task SaveAsync(Castle castle)
        {
            using (var ctx = _contextCreator())
            {
                ctx.Castles.Attach(castle);
                ctx.Entry(castle).State = EntityState.Modified;
                await ctx.SaveChangesAsync();
            }
        }
    }
}
