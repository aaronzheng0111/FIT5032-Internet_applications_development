namespace week5Lec_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingAuthorToBooks : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Author", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Author");
        }
    }
}
