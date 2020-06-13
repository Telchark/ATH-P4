using MapDemo.DataAccess;
using MapDemo.Model;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace MapDemo.UI.Data
{
    public class WeaponDataService : IWeaponDataService
    {
        private Func<MapDemoDbContext> _contextCreator;

        public WeaponDataService(Func<MapDemoDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }
        public async Task<Weapon> GetByIdAsync(int weaponId)
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Weapons.AsNoTracking().SingleAsync(w => w.WeaponId == weaponId);
            }
        }

        public async Task SaveAsync(Weapon weapon)
        {
            using (var ctx = _contextCreator())
            {
                ctx.Weapons.Attach(weapon);
                ctx.Entry(weapon).State = EntityState.Modified;
                await ctx.SaveChangesAsync();
            }
        }
    }
}
