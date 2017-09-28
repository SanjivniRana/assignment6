namespace Assignment6.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ioctbl : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employee1", "EName", c => c.String());
            AlterColumn("dbo.Employee1", "Email", c => c.String());
            AlterColumn("dbo.Employee1", "State", c => c.String());
            AlterColumn("dbo.Employee1", "City", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employee1", "City", c => c.String(nullable: false));
            AlterColumn("dbo.Employee1", "State", c => c.String(nullable: false));
            AlterColumn("dbo.Employee1", "Email", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Employee1", "EName", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
