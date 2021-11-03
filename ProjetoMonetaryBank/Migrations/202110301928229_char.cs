namespace Forms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _char : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Sexo", c => c.String(maxLength: 1));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Sexo");
        }
    }
}
