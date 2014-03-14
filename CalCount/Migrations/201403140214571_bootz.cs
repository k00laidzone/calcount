namespace CalCount.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bootz : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.sidedishs", "name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.sidedishs", "name", c => c.String());
        }
    }
}
