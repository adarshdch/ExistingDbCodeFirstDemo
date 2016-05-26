namespace ExistingDbCodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DemoMigration : DbMigration
    {
        public override void Up()
        {
            /*CreateTable(
                "dbo.ExistingTable",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Data = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);*/
            
            CreateTable(
                "dbo.NewTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Data = c.String(),
                        UpdateDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NewTables");
            //DropTable("dbo.ExistingTable");
        }
    }
}
