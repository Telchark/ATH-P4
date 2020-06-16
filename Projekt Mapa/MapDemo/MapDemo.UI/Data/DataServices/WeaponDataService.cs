using MapDemo.DataAccess;
using MapDemo.Model;
using System.Data.Entity;
using System.Threading.Tasks;

namespace MapDemo.UI.Data
{
    public class WeaponDataService : IWeaponDataService
    {
        private MapDemoDbContext _context;

        public WeaponDataService(MapDemoDbContext context)
        {
            _context = context;
        }

        public async Task<Weapon> GetByIdAsync(int weaponId)
        {
            return await _context.Weapons.SingleAsync(w => w.WeaponId == weaponId);
        }
        public void Add(Weapon weapon)
        {
            _context.Weapons.Add(weapon);
        }
        public bool HasChanges()
        {
            return _context.ChangeTracker.HasChanges();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Remove(Weapon model)
        {
            _context.Weapons.Remove(model);
        }
    }
}
//tworzymy context i stosujemy na nim metody