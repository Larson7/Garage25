namespace Garage2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class memberid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "MemberId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vehicles", "MemberId");
        }
    }
}
