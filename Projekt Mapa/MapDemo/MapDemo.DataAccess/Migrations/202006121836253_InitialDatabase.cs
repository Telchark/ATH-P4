namespace MapDemo.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Armors",
                c => new
                    {
                        ArmorId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Type = c.Int(nullable: false),
                        Weight = c.Double(nullable: false),
                        ArmorValue = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ArmorId);
            
            CreateTable(
                "dbo.Castles",
                c => new
                    {
                        CastleId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CastleId);
            
            CreateTable(
                "dbo.Resources",
                c => new
                    {
                        ResourceId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ResourceId);
            
            CreateTable(
                "dbo.Weapons",
                c => new
                    {
                        WeaponId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Type = c.Int(nullable: false),
                        Weight = c.Double(nullable: false),
                        Length = c.Int(nullable: false),
                        Damage = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WeaponId);
            
            CreateTable(
                "dbo.CastleArmors",
                c => new
                    {
                        Castle_CastleId = c.Int(nullable: false),
                        Armor_ArmorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Castle_CastleId, t.Armor_ArmorId })
                .ForeignKey("dbo.Castles", t => t.Castle_CastleId, cascadeDelete: true)
                .ForeignKey("dbo.Armors", t => t.Armor_ArmorId, cascadeDelete: true)
                .Index(t => t.Castle_CastleId)
                .Index(t => t.Armor_ArmorId);
            
            CreateTable(
                "dbo.ResourceCastles",
                c => new
                    {
                        Resource_ResourceId = c.Int(nullable: false),
                        Castle_CastleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Resource_ResourceId, t.Castle_CastleId })
                .ForeignKey("dbo.Resources", t => t.Resource_ResourceId, cascadeDelete: true)
                .ForeignKey("dbo.Castles", t => t.Castle_CastleId, cascadeDelete: true)
                .Index(t => t.Resource_ResourceId)
                .Index(t => t.Castle_CastleId);
            
            CreateTable(
                "dbo.WeaponCastles",
                c => new
                    {
                        Weapon_WeaponId = c.Int(nullable: false),
                        Castle_CastleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Weapon_WeaponId, t.Castle_CastleId })
                .ForeignKey("dbo.Weapons", t => t.Weapon_WeaponId, cascadeDelete: true)
                .ForeignKey("dbo.Castles", t => t.Castle_CastleId, cascadeDelete: true)
                .Index(t => t.Weapon_WeaponId)
                .Index(t => t.Castle_CastleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WeaponCastles", "Castle_CastleId", "dbo.Castles");
            DropForeignKey("dbo.WeaponCastles", "Weapon_WeaponId", "dbo.Weapons");
            DropForeignKey("dbo.ResourceCastles", "Castle_CastleId", "dbo.Castles");
            DropForeignKey("dbo.ResourceCastles", "Resource_ResourceId", "dbo.Resources");
            DropForeignKey("dbo.CastleArmors", "Armor_ArmorId", "dbo.Armors");
            DropForeignKey("dbo.CastleArmors", "Castle_CastleId", "dbo.Castles");
            DropIndex("dbo.WeaponCastles", new[] { "Castle_CastleId" });
            DropIndex("dbo.WeaponCastles", new[] { "Weapon_WeaponId" });
            DropIndex("dbo.ResourceCastles", new[] { "Castle_CastleId" });
            DropIndex("dbo.ResourceCastles", new[] { "Resource_ResourceId" });
            DropIndex("dbo.CastleArmors", new[] { "Armor_ArmorId" });
            DropIndex("dbo.CastleArmors", new[] { "Castle_CastleId" });
            DropTable("dbo.WeaponCastles");
            DropTable("dbo.ResourceCastles");
            DropTable("dbo.CastleArmors");
            DropTable("dbo.Weapons");
            DropTable("dbo.Resources");
            DropTable("dbo.Castles");
            DropTable("dbo.Armors");
        }
    }
}
