using MapDemo.DataAccess;
using MapDemo.Model;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace MapDemo.UI.Data
{
    public class ArmorDataService : IArmorDataService
    {
        private Func<MapDemoDbContext> _contextCreator;

        public ArmorDataService(Func<MapDemoDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }
        public async Task<Armor> GetByIdAsync(int armorId)
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Armors.AsNoTracking().SingleAsync(a => a.ArmorId == armorId);
            }
        }
        public async Task SaveAsync(Armor armor)
        {
            using (var ctx = _contextCreator())
            {
                ctx.Armors.Attach(armor);
                ctx.Entry(armor).State = EntityState.Modified;
                await ctx.SaveChangesAsync();
            }
        }
    }
}
