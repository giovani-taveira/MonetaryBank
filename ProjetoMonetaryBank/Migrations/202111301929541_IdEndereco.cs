namespace Forms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IdEndereco : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Enderecoes");
            AddColumn("dbo.Enderecoes", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Enderecoes", "Cep", c => c.String(maxLength: 9));
            AddPrimaryKey("dbo.Enderecoes", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Enderecoes");
            AlterColumn("dbo.Enderecoes", "Cep", c => c.String(nullable: false, maxLength: 9));
            DropColumn("dbo.Enderecoes", "Id");
            AddPrimaryKey("dbo.Enderecoes", "Cep");
        }
    }
}
