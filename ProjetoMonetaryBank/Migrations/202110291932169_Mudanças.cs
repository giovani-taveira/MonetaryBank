namespace Forms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mudanças : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Clientes");
            AddColumn("dbo.Logins", "Saldo", c => c.Decimal(nullable: false, storeType: "money"));
            AlterColumn("dbo.Clientes", "CPF", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Clientes", "CPF");
            CreateIndex("dbo.Clientes", "CPF");
            AddForeignKey("dbo.Clientes", "CPF", "dbo.Logins", "cpf");
            DropColumn("dbo.Clientes", "Saldo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "Saldo", c => c.Double(nullable: false));
            DropForeignKey("dbo.Clientes", "CPF", "dbo.Logins");
            DropIndex("dbo.Clientes", new[] { "CPF" });
            DropPrimaryKey("dbo.Clientes");
            AlterColumn("dbo.Clientes", "CPF", c => c.String(nullable: false, maxLength: 14));
            DropColumn("dbo.Logins", "Saldo");
            AddPrimaryKey("dbo.Clientes", "CPF");
        }
    }
}
