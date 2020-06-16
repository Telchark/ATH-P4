using MapDemo.DataAccess;
using MapDemo.Model;
using System.Data.Entity;
using System.Threading.Tasks;

namespace MapDemo.UI.Data
{
    public class ArmorDataService : IArmorDataService
    {
        private MapDemoDbContext _context;

        public ArmorDataService(MapDemoDbContext context)
        {
            _context = context;
        }

        public void Add(Armor armor)
        {
            _context.Armors.Add(armor);
        }

        public async Task<Armor> GetByIdAsync(int armorId)
        {
            return await _context.Armors.SingleAsync(a => a.ArmorId == armorId);
        }

        public bool HasChanges()
        {
            return _context.ChangeTracker.HasChanges();
        }

        public void Remove(Armor armor)
        {
            _context.Armors.Remove(armor);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
