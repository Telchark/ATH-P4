namespace MapDemo.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeResourcePriceFromFloatToInt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Resources", "Price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Resources", "Price", c => c.Single(nullable: false));
        }
    }
}
