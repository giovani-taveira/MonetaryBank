namespace Forms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Historico : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Historicoes",
                c => new
                    {
                        Codigo_Operacao_ID = c.Int(nullable: false, identity: true),
                        CPF = c.String(maxLength: 14),
                        Operacao = c.String(maxLength: 20),
                        Valor = c.Double(nullable: false),
                        NomeRecebedor = c.String(),
                        Data_Operacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Codigo_Operacao_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Historicoes");
        }
    }
}
