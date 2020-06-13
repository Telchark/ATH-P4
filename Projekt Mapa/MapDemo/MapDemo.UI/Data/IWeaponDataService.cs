using MapDemo.Model;
using System.Collections.Generic;

namespace MapDemo.UI.Data
{
    public interface IWeaponDataService
    {
        IEnumerable<Weapon> GetAll();
    }
}