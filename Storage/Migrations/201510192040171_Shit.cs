namespace Storage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Shit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategorySelections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CategorySelections");
        }
    }
}
