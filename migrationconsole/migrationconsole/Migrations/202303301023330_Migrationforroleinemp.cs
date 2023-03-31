namespace migrationconsole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migrationforroleinemp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "erole", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "erole");
        }
    }
}
