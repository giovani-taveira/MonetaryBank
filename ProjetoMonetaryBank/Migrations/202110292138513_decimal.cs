namespace Forms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _decimal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "Renda", c => c.Decimal(nullable: false, storeType: "money"));
            AlterColumn("dbo.Historicoes", "Valor", c => c.Decimal(nullable: false, storeType: "money"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Historicoes", "Valor", c => c.Double(nullable: false));
            AlterColumn("dbo.Clientes", "Renda", c => c.String(maxLength: 15));
        }
    }
}
