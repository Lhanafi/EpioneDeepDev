namespace Epione.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "speciality", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "speciality", c => c.Int());
        }
    }
}
