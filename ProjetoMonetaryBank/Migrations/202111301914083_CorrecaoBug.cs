namespace Forms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrecaoBug : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Enderecoes");
            AlterColumn("dbo.Enderecoes", "Cep", c => c.String(nullable: false, maxLength: 9));
            AddPrimaryKey("dbo.Enderecoes", "Cep");
            DropColumn("dbo.Enderecoes", "EnderecoId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Enderecoes", "EnderecoId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Enderecoes");
            AlterColumn("dbo.Enderecoes", "Cep", c => c.String(maxLength: 9));
            AddPrimaryKey("dbo.Enderecoes", "EnderecoId");
        }
    }
}
