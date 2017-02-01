namespace vNext.SM.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserTableAdded31 : DbMigration
    {
        public override void Up()
        {
            AlterStoredProcedure(
        "dbo.sp_AddNewUser",
        p => new
        {
            UserId = p.String(maxLength: 20),
            UserPassport = p.String(maxLength: 50),
            UserRole = p.String(maxLength: 3),
            CreatedBy = p.String(maxLength: 50),
            UpdatedBy = p.String(maxLength: 50)

        },
        body:
            @"INSERT [dbo].[SMUser]([UserId],[UserPassport], [UserRole], [CreatedBy],[UpdatedBy],[UpdatedOn])
                VALUES (@UserId,@UserPassport, @UserRole, @CreatedBy,@UpdatedBy,getdate())"
    );
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.sp_AddNewUser");
        }
    }
}
