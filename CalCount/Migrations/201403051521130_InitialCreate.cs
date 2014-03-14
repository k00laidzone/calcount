namespace CalCount.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.calcounts",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        category = c.String(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Desc = c.String(nullable: false),
                        CaloriesCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.calcounts");
        }
    }
}
