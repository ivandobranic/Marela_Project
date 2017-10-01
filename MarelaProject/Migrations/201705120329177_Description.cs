namespace MarelaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Description : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MarelaModels", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MarelaModels", "Description");
        }
    }
}
