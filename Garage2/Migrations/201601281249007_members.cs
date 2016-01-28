namespace Garage2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class members : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        MemberId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        TelNr = c.String(),
                        Mail = c.String(),
                    })
                .PrimaryKey(t => t.MemberId);
            
            CreateIndex("dbo.Vehicles", "MemberId");
            AddForeignKey("dbo.Vehicles", "MemberId", "dbo.Members", "MemberId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicles", "MemberId", "dbo.Members");
            DropIndex("dbo.Vehicles", new[] { "MemberId" });
            DropTable("dbo.Members");
        }
    }
}
