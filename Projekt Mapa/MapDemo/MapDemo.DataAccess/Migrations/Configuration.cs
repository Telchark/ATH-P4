namespace MapDemo.DataAccess.Migrations
{
    using MapDemo.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MapDemo.DataAccess.MapDemoDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MapDemo.DataAccess.MapDemoDbContext context)
        {
            context.Armors.AddOrUpdate(
                a => a.ArmorId,
                new Armor { ArmorId = 1, Name = "Elite Armor", Type = Armor.ArmorType.Body, ArmorValue = 48, Price = 7200, Weight = 12.5 },
                new Armor { ArmorId = 2, Name = "Plate Armor", Type = Armor.ArmorType.Body, ArmorValue = 60, Price = 52000, Weight = 21.5 },
                new Armor { ArmorId = 3, Name = "Coat of Plates", Type = Armor.ArmorType.Body, ArmorValue = 52, Price = 9000, Weight = 10.0 },
                new Armor { ArmorId = 4, Name = "Heavy Hauberk", Type = Armor.ArmorType.Body, ArmorValue = 38, Price = 3900, Weight = 8.5 });
            context.Weapons.AddOrUpdate(
                a => a.WeaponId,
                new Weapon { WeaponId = 1, Name = "Pike", Type = Weapon.WeaponType.Polearm, Damage = 34, Price = 1200, Weight = 7, Length = 210 },
                new Weapon { WeaponId = 2, Name = "Swadian Sword", Type = Weapon.WeaponType.One_handed, Damage = 31, Price = 840, Weight = 1.7, Length = 84 },
                new Weapon { WeaponId = 3, Name = "Great Sword", Type = Weapon.WeaponType.Two_handed, Damage = 44, Price = 5500, Weight = 3.8, Length = 124 },
                new Weapon { WeaponId = 4, Name = "Bardiche", Type = Weapon.WeaponType.Two_handed, Damage = 52, Price = 2700, Weight = 4.0, Length = 156 });
            context.Resources.AddOrUpdate(
                a => a.ResourceId,
                new Resource { ResourceId = 1, Name = "Iron", Price = 1145 },
                new Resource { ResourceId = 2, Name = "Wood", Price = 420 },
                new Resource { ResourceId = 3, Name = "Leather", Price = 645 },
                new Resource { ResourceId = 4, Name = "Linen Cloth", Price = 240 });
            context.Castles.AddOrUpdate(
                a => a.CastleId,
                new Castle { CastleId = 1, Name = "Kildevalk" },
                new Castle { CastleId = 2, Name = "Praven" },
                new Castle { CastleId = 3, Name = "Sargoth"},
                new Castle { CastleId = 4, Name = "Jelkala"});
        }
    }
}
