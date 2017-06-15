namespace MTVideos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testingschemeannotations : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Movies");
            AlterColumn("dbo.Movies", "Id", c => c.Byte(nullable: false, identity: true));
            AddPrimaryKey("dbo.Movies", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Movies");
            AlterColumn("dbo.Movies", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Movies", "Id");
        }
    }
}
