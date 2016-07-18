namespace Cruzeiro.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PortalName : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.EventoPortal", new[] { "Pessoa_Id" });
            RenameColumn(table: "dbo.EventoPortal", name: "Pessoa_Id", newName: "PessoaId");
            AddColumn("dbo.EventoPortal", "PortalName", c => c.String());
            AddColumn("dbo.Leitor", "EstabelecimentoId", c => c.Int(nullable: false));
            AlterColumn("dbo.EventoPortal", "PessoaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Leitor", "EstabelecimentoId");
            CreateIndex("dbo.EventoPortal", "PessoaId");
            AddForeignKey("dbo.Leitor", "EstabelecimentoId", "dbo.Estabelecimento", "Id");
            DropColumn("dbo.EventoPortal", "PessoaPortalId");
            DropColumn("dbo.EventoPortal", "Epc");
            DropColumn("dbo.EventoPortal", "Portal");
            DropColumn("dbo.Leitor", "LeitorId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Leitor", "LeitorId", c => c.Int(nullable: false));
            AddColumn("dbo.EventoPortal", "Portal", c => c.Int(nullable: false));
            AddColumn("dbo.EventoPortal", "Epc", c => c.String());
            AddColumn("dbo.EventoPortal", "PessoaPortalId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Leitor", "EstabelecimentoId", "dbo.Estabelecimento");
            DropIndex("dbo.EventoPortal", new[] { "PessoaId" });
            DropIndex("dbo.Leitor", new[] { "EstabelecimentoId" });
            AlterColumn("dbo.EventoPortal", "PessoaId", c => c.Int());
            DropColumn("dbo.Leitor", "EstabelecimentoId");
            DropColumn("dbo.EventoPortal", "PortalName");
            RenameColumn(table: "dbo.EventoPortal", name: "PessoaId", newName: "Pessoa_Id");
            CreateIndex("dbo.EventoPortal", "Pessoa_Id");
        }
    }
}
