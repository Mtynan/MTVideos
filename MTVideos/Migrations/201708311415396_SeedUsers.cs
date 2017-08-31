namespace MTVideos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0e4df48b-2add-4ff7-9db3-2504ed63be2a', N'admin@MTVideos.com', 0, N'AHroAkrljGjHstAbUTw6it3s2cA3Yb25FMBJZDDn8Aq+YtUIHcq/a/WKx0Ybjp9ZUQ==', N'4c4678e1-a93e-4f7a-ae81-9a009990c257', NULL, 0, 0, NULL, 1, 0, N'admin@MTVideos.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'91120ebb-b926-4995-aa09-b861af775d98', N'guest@MTVideos.com', 0, N'AKm3/F/yMesV9zLoUSPkflFf2E6iynVljYNro5cfPG/l779meGhmfAhh1SG/xan1PA==', N'afcdf338-fbff-43a6-a4b4-440e0803b217', NULL, 0, 0, NULL, 1, 0, N'guest@MTVideos.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a6bd54f6-f4a5-4d28-9a6a-972f0ff56c64', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0e4df48b-2add-4ff7-9db3-2504ed63be2a', N'a6bd54f6-f4a5-4d28-9a6a-972f0ff56c64')



");
        }
        
        public override void Down()
        {
        }
    }
}
