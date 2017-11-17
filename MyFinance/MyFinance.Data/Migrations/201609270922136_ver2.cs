namespace MyFinance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ver2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "desc", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "desc");
        }
    }
}
