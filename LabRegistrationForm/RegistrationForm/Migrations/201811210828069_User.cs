namespace RegistrationForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class User : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Address", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Users", "Adress");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Adress", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Users", "Address");
        }
    }
}
