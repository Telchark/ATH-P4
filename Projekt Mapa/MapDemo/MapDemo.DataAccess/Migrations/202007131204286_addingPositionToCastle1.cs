namespace MapDemo.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingPositionToCastle1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Castles", "X", c => c.Int(nullable: false));
            AlterColumn("dbo.Castles", "Y", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Castles", "Y", c => c.String(nullable: false));
            AlterColumn("dbo.Castles", "X", c => c.String(nullable: false));
        }
    }
}
