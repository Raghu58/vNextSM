namespace vNext.SM.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserTableAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SMUser",
                c => new
                    {
                        SMUserId = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        UserPassport = c.String(),
                        UserRole = c.String(),
                        CreatedBy = c.String(),
                        UpdatedBy = c.String(),
                        UpdatedOn = c.DateTime(nullable: false),
                        CreatedOn = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.SMUserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SMUser");
        }
    }
}
