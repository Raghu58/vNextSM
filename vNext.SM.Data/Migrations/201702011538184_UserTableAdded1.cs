namespace vNext.SM.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserTableAdded1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SMUser", "UserId", c => c.String(maxLength: 50));
            AlterColumn("dbo.SMUser", "UserPassport", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SMUser", "UserPassport", c => c.String());
            AlterColumn("dbo.SMUser", "UserId", c => c.String());
        }
    }
}
