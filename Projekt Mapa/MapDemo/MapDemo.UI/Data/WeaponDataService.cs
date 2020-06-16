using MapDemo.DataAccess;
using MapDemo.Model;
using System.Collections.Generic;
using System.Linq;

namespace MapDemo.UI.Data
{
    public class WeaponDataService : IWeaponDataService
    {
        public IEnumerable<Weapon> GetAll()
        {
           using(var context = new MapDemoDbContext())
            {
                context.Weapons.AsNoTracking().ToLisWt();
            }
        }
    }
}
