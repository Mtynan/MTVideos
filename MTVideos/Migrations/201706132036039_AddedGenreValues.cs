namespace MTVideos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGenreValues : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Horror')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Sci-Fi')");
        }
        
        public override void Down()
        {
        }
    }
}
