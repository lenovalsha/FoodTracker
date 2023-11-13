namespace FoodTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        FoodDate = c.DateTime(),
                        MealId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Meals", t => t.MealId, cascadeDelete: true)
                .Index(t => t.MealId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Foods", "MealId", "dbo.Meals");
            DropIndex("dbo.Foods", new[] { "MealId" });
            DropTable("dbo.Foods");
        }
    }
}
