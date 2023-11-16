namespace FoodTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class init5 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MEALS (Name) VALUES('Snack');");
        }

        public override void Down()
        {
        }
    }
}
