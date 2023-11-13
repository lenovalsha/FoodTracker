namespace FoodTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMealSeedtoDB : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MEALS (Name) VALUES('Breakfast');");
            Sql("INSERT INTO MEALS (Name) VALUES('Lunch');");
            Sql("INSERT INTO MEALS (Name) VALUES('Supper');");

        }

        public override void Down()
        {
            //we really should put some delete statements in here
        }
    }
}
