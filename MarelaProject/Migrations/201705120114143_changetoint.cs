namespace MarelaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changetoint : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MarelaModels", "FileSize", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MarelaModels", "FileSize", c => c.String());
        }
    }
}
