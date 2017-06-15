namespace MTVideos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testnulldatetimeinmovies1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "DateReleased", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTime());
            AlterColumn("dbo.Movies", "DateReleased", c => c.DateTime());
        }
    }
}
