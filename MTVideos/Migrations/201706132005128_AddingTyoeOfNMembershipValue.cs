namespace MTVideos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingTyoeOfNMembershipValue : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET TypeOfMembership = 'Pay as You Go' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET TypeOfMembership = 'Monthly' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET TypeOfMembership = 'Quarterly' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET TypeOfMembership = 'Annually' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
