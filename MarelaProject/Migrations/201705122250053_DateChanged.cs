namespace MarelaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MarelaModels", "FirstDate", c => c.DateTime());
            AlterColumn("dbo.MarelaModels", "LastModification", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MarelaModels", "LastModification", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MarelaModels", "FirstDate", c => c.DateTime(nullable: false));
        }
    }
}
