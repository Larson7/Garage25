namespace Garage2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Vehicles");
            CreateTable(
                "dbo.TypeVehicles",
                c => new
                    {
                        TypeVehicleId = c.Int(nullable: false, identity: true),
                        VType = c.String(),
                        Brand = c.String(),
                        ProdName = c.String(),
                        Wheels = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TypeVehicleId);
            DropColumn("dbo.Vehicles", "Id");
            DropColumn("dbo.Vehicles", "Type");
            DropColumn("dbo.Vehicles", "Brand");
            DropColumn("dbo.Vehicles", "ProdName");
            DropColumn("dbo.Vehicles", "Wheels");
            AddColumn("dbo.Vehicles", "VehicleId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Vehicles", "TypeVehicle_TypeVehicleId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Vehicles", "VehicleId");
            CreateIndex("dbo.Vehicles", "TypeVehicle_TypeVehicleId");
            AddForeignKey("dbo.Vehicles", "TypeVehicle_TypeVehicleId", "dbo.TypeVehicles", "TypeVehicleId", cascadeDelete: true);
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vehicles", "Wheels", c => c.Int(nullable: false));
            AddColumn("dbo.Vehicles", "ProdName", c => c.String());
            AddColumn("dbo.Vehicles", "Brand", c => c.String());
            AddColumn("dbo.Vehicles", "Type", c => c.Int(nullable: false));
            AddColumn("dbo.Vehicles", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Vehicles", "TypeVehicle_TypeVehicleId", "dbo.TypeVehicles");
            DropIndex("dbo.Vehicles", new[] { "TypeVehicle_TypeVehicleId" });
            DropPrimaryKey("dbo.Vehicles");
            DropColumn("dbo.Vehicles", "TypeVehicle_TypeVehicleId");
            DropColumn("dbo.Vehicles", "VehicleId");
            DropTable("dbo.TypeVehicles");
            AddPrimaryKey("dbo.Vehicles", "Id");
        }
    }
}
