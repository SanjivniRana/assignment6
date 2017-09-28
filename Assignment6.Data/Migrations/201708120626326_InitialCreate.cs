namespace Assignment6.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employee1",
                c => new
                    {
                        EId = c.Int(nullable: false, identity: true),
                        EName = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 20),
                        Phone = c.Long(nullable: false),
                        MaritalStatus = c.Boolean(nullable: false),
                        State = c.String(nullable: false),
                        City = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.EId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employee1");
        }
    }
}
