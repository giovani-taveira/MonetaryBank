namespace Forms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class campo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Logins", "Senha", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Logins", "Senha", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
