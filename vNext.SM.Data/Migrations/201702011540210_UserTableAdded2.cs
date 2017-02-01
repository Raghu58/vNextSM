namespace vNext.SM.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserTableAdded2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SMUser", "UserRole", c => c.String(maxLength: 3));
            AlterColumn("dbo.SMUser", "CreatedBy", c => c.String(maxLength: 50));
            AlterColumn("dbo.SMUser", "UpdatedBy", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SMUser", "UpdatedBy", c => c.String());
            AlterColumn("dbo.SMUser", "CreatedBy", c => c.String());
            AlterColumn("dbo.SMUser", "UserRole", c => c.String());
        }
    }
}
