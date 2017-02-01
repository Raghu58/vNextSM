namespace vNext.SM.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserTableAdded3 : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure(
        "dbo.sp_AddNewUser",
        p => new
        {
            UserId = p.String(maxLength: 20),
            UserPassport = p.String(maxLength: 50),
            RoleId = p.String(maxLength: 3),
            CreatedBy= p.String(maxLength: 50),
            UpdatedBy = p.String(maxLength: 50)
           
    },
        body:
            @"INSERT [dbo].[SMUser]([UserId],[UserPassport], [RoleId], [CreatedBy],[UpdatedBy],[UpdatedOn])
                VALUES (@UserId,@UserPassport, @RoleId, @CreatedBy,@UpdatedBy,getdate())"
    );
        }
        
        public override void Down()
        {
        }
    }
}


