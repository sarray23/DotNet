namespace MyFinance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v6 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Categories", newName: "MyCategory");
            AlterColumn("dbo.MyCategory", "name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MyCategory", "name", c => c.String());
            RenameTable(name: "dbo.MyCategory", newName: "Categories");
        }
    }
}
