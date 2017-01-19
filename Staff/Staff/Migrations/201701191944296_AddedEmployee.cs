namespace Staff.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedEmployee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        Position = c.String(nullable: false),
                        ChiefId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.ChiefId)
                .Index(t => t.ChiefId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "ChiefId", "dbo.Employees");
            DropIndex("dbo.Employees", new[] { "ChiefId" });
            DropTable("dbo.Employees");
        }
    }
}
