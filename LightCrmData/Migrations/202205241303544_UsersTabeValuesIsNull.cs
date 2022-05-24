namespace LightCrmData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsersTabeValuesIsNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Surname", c => c.String());
            AlterColumn("dbo.Users", "Patronymic", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Patronymic", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Surname", c => c.String(nullable: false));
        }
    }
}
