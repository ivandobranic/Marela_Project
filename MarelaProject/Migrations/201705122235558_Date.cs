namespace MarelaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Date : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MarelaModels", "FirstDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.MarelaModels", "LastModification", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MarelaModels", "LastModification");
            DropColumn("dbo.MarelaModels", "FirstDate");
        }
    }
}
