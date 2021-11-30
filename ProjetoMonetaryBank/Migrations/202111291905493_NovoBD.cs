namespace Forms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NovoBD : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        CPF = c.String(nullable: false, maxLength: 128),
                        Nome = c.String(maxLength: 50),
                        Sexo = c.String(maxLength: 1),
                        RG = c.String(maxLength: 12),
                        Email = c.String(maxLength: 100),
                        Nacimento = c.String(maxLength: 10),
                        Telefone = c.String(maxLength: 14),
                        NomeMae = c.String(maxLength: 50),
                        NaoConstaMae = c.Boolean(nullable: false),
                        NomePai = c.String(maxLength: 50),
                        NaoConstaPai = c.Boolean(nullable: false),
                        CEP = c.String(maxLength: 9),
                        Profissao = c.String(maxLength: 50),
                        Renda = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => t.CPF)
                .ForeignKey("dbo.Enderecoes", t => t.CEP)
                .ForeignKey("dbo.Logins", t => t.CPF)
                .Index(t => t.CPF)
                .Index(t => t.CEP);
            
            CreateTable(
                "dbo.Enderecoes",
                c => new
                    {
                        Cep = c.String(nullable: false, maxLength: 9),
                        Logradouro = c.String(maxLength: 100),
                        Numero = c.String(maxLength: 10),
                        Complemento = c.String(maxLength: 100),
                        Bairro = c.String(maxLength: 50),
                        Cidade = c.String(maxLength: 50),
                        Estado = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Cep);
            
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        cpf = c.String(nullable: false, maxLength: 128),
                        Senha = c.String(maxLength: 50),
                        Saldo = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => t.cpf);
            
            CreateTable(
                "dbo.Historicoes",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Cpf = c.String(maxLength: 14),
                        Operacao = c.String(maxLength: 20),
                        Valor = c.Decimal(nullable: false, storeType: "money"),
                        NomeRecebedor = c.String(),
                        Data_Operacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Codigo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "CPF", "dbo.Logins");
            DropForeignKey("dbo.Clientes", "CEP", "dbo.Enderecoes");
            DropIndex("dbo.Clientes", new[] { "CEP" });
            DropIndex("dbo.Clientes", new[] { "CPF" });
            DropTable("dbo.Historicoes");
            DropTable("dbo.Logins");
            DropTable("dbo.Enderecoes");
            DropTable("dbo.Clientes");
        }
    }
}
