namespace Cruzeiro.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class altera_pessoa : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Pessoa", new[] { "EstabelecimentoId" });
            DropIndex("dbo.Pessoa", new[] { "TurmaId" });
            AlterColumn("dbo.Pessoa", "Matricula", c => c.Int());
            AlterColumn("dbo.Pessoa", "EstabelecimentoId", c => c.Int());
            AlterColumn("dbo.Pessoa", "TurmaId", c => c.Int());
            AlterColumn("dbo.Pessoa", "AnoEntrada", c => c.Int());
            CreateIndex("dbo.Pessoa", "EstabelecimentoId");
            CreateIndex("dbo.Pessoa", "TurmaId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Pessoa", new[] { "TurmaId" });
            DropIndex("dbo.Pessoa", new[] { "EstabelecimentoId" });
            AlterColumn("dbo.Pessoa", "AnoEntrada", c => c.Int(nullable: false));
            AlterColumn("dbo.Pessoa", "TurmaId", c => c.Int(nullable: false));
            AlterColumn("dbo.Pessoa", "EstabelecimentoId", c => c.Int(nullable: false));
            AlterColumn("dbo.Pessoa", "Matricula", c => c.Int(nullable: false));
            CreateIndex("dbo.Pessoa", "TurmaId");
            CreateIndex("dbo.Pessoa", "EstabelecimentoId");
        }
    }
}
