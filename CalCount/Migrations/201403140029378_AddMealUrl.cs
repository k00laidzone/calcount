namespace CalCount.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMealUrl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.sidedishs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        name = c.String(),
                        calories = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.sidedishs");
        }
    }
}
