using MapDemo.DataAccess;
using MapDemo.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MapDemo.UI.Data
{
    public class LookupWeaponDataService : ILookupWeaponDataService
    {
        private Func<MapDemoDbContext> _contextCreator;

        public LookupWeaponDataService(Func<MapDemoDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }
        public async Task<IEnumerable<LookupWeapon>> GetWeaponLookupAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Weapons.AsNoTracking()
                    .Select(w =>
                    new LookupWeapon
                    {
                        WeaponId = w.WeaponId,
                        WeaponName = w.Name
                    }).ToListAsync();
            }
        }
    }
}
