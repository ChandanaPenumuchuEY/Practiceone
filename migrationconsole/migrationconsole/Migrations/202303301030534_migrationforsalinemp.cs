namespace migrationconsole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationforsalinemp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "esal", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "esal");
        }
    }
}
