namespace MapDemo.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingPositionToCastle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Castles", "X", c => c.String(nullable: false));
            AddColumn("dbo.Castles", "Y", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Castles", "Y");
            DropColumn("dbo.Castles", "X");
        }
    }
}
