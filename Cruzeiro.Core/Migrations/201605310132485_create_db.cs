namespace Cruzeiro.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_db : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Curso",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastChange = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Turma",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EstabelecimentoId = c.Int(nullable: false),
                        CursoId = c.Int(nullable: false),
                        Name = c.String(),
                        LastChange = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Curso", t => t.CursoId)
                .ForeignKey("dbo.Estabelecimento", t => t.EstabelecimentoId)
                .Index(t => t.EstabelecimentoId)
                .Index(t => t.CursoId);
            
            CreateTable(
                "dbo.Estabelecimento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastChange = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Epc = c.String(),
                        Matricula = c.Int(nullable: false),
                        EstabelecimentoId = c.Int(nullable: false),
                        TurmaId = c.Int(nullable: false),
                        AnoEntrada = c.Int(nullable: false),
                        Documento = c.String(),
                        TipoPessoaId = c.Int(nullable: false),
                        Name = c.String(),
                        LastChange = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estabelecimento", t => t.EstabelecimentoId)
                .ForeignKey("dbo.Turma", t => t.TurmaId)
                .Index(t => t.EstabelecimentoId)
                .Index(t => t.TurmaId);
            
            CreateTable(
                "dbo.EventoPortal",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PessoaPortalId = c.Int(nullable: false),
                        SentidoEvento = c.Int(nullable: false),
                        Epc = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        Portal = c.Int(nullable: false),
                        StatusEvento = c.Int(nullable: false),
                        LastChange = c.DateTime(nullable: false),
                        Pessoa_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.Pessoa_Id)
                .Index(t => t.Pessoa_Id);
            
            CreateTable(
                "dbo.RegraPortal",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DiaSemana = c.Int(),
                        DataEspecifica = c.DateTime(),
                        TurmaId = c.Int(),
                        PessoaId = c.Int(),
                        Entrada = c.Time(nullable: false, precision: 7),
                        Saida = c.Time(nullable: false, precision: 7),
                        LastChange = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.PessoaId)
                .ForeignKey("dbo.Turma", t => t.TurmaId)
                .Index(t => t.TurmaId)
                .Index(t => t.PessoaId);
            
            CreateTable(
                "dbo.ReaderConfig",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EstabelecimentoId = c.Int(nullable: false),
                        Portal = c.Int(nullable: false),
                        ReaderType = c.Int(nullable: false),
                        Address = c.String(),
                        AntennasStr = c.String(),
                        LastChange = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estabelecimento", t => t.EstabelecimentoId)
                .Index(t => t.EstabelecimentoId);
            
            CreateTable(
                "dbo.TipoPessoa",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReaderConfig", "EstabelecimentoId", "dbo.Estabelecimento");
            DropForeignKey("dbo.Turma", "EstabelecimentoId", "dbo.Estabelecimento");
            DropForeignKey("dbo.Pessoa", "TurmaId", "dbo.Turma");
            DropForeignKey("dbo.RegraPortal", "TurmaId", "dbo.Turma");
            DropForeignKey("dbo.RegraPortal", "PessoaId", "dbo.Pessoa");
            DropForeignKey("dbo.EventoPortal", "Pessoa_Id", "dbo.Pessoa");
            DropForeignKey("dbo.Pessoa", "EstabelecimentoId", "dbo.Estabelecimento");
            DropForeignKey("dbo.Turma", "CursoId", "dbo.Curso");
            DropIndex("dbo.ReaderConfig", new[] { "EstabelecimentoId" });
            DropIndex("dbo.RegraPortal", new[] { "PessoaId" });
            DropIndex("dbo.RegraPortal", new[] { "TurmaId" });
            DropIndex("dbo.EventoPortal", new[] { "Pessoa_Id" });
            DropIndex("dbo.Pessoa", new[] { "TurmaId" });
            DropIndex("dbo.Pessoa", new[] { "EstabelecimentoId" });
            DropIndex("dbo.Turma", new[] { "CursoId" });
            DropIndex("dbo.Turma", new[] { "EstabelecimentoId" });
            DropTable("dbo.TipoPessoa");
            DropTable("dbo.ReaderConfig");
            DropTable("dbo.RegraPortal");
            DropTable("dbo.EventoPortal");
            DropTable("dbo.Pessoa");
            DropTable("dbo.Estabelecimento");
            DropTable("dbo.Turma");
            DropTable("dbo.Curso");
        }
    }
}
