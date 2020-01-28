namespace WebApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BusinessPartner",
                c => new
                    {
                        BusinessPartnerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        LoginName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.BusinessPartnerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BusinessPartner");
        }
    }
}
