namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovie : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.Movies", new[] { "Movie_Id" });
            DropColumn("dbo.Movies", "Movie_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Movie_Id", c => c.Int());
            CreateIndex("dbo.Movies", "Movie_Id");
            AddForeignKey("dbo.Movies", "Movie_Id", "dbo.Movies", "Id");
        }
    }
}
