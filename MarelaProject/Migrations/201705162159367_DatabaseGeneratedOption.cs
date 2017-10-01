namespace MarelaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseGeneratedOption : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MarelaModels", "FirstDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MarelaModels", "FirstDate", c => c.DateTime());
        }
    }
}
