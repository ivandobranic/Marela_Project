namespace MarelaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotationChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MarelaModels", "InvestigationNumber", c => c.String(nullable: false, maxLength: 16));
            AlterColumn("dbo.MarelaModels", "CompanyName", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.MarelaModels", "MalwareName", c => c.String(maxLength: 25));
            AlterColumn("dbo.MarelaModels", "FileType", c => c.String(maxLength: 6));
            AlterColumn("dbo.MarelaModels", "FileSize", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MarelaModels", "FileSize", c => c.Int(nullable: false));
            AlterColumn("dbo.MarelaModels", "FileType", c => c.String());
            AlterColumn("dbo.MarelaModels", "MalwareName", c => c.String());
            AlterColumn("dbo.MarelaModels", "CompanyName", c => c.String());
            AlterColumn("dbo.MarelaModels", "InvestigationNumber", c => c.String());
        }
    }
}
