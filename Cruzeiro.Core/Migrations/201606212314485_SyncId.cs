namespace Cruzeiro.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SyncId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Curso", "SyncId", c => c.Int());
            AddColumn("dbo.Turma", "SyncId", c => c.Int());
            AddColumn("dbo.Estabelecimento", "SyncId", c => c.Int());
            AddColumn("dbo.Pessoa", "SyncId", c => c.Int());
            AddColumn("dbo.EventoPortal", "SyncId", c => c.Int());
            AddColumn("dbo.RegraPortal", "SyncId", c => c.Int());
            AddColumn("dbo.ReaderConfig", "SyncId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ReaderConfig", "SyncId");
            DropColumn("dbo.RegraPortal", "SyncId");
            DropColumn("dbo.EventoPortal", "SyncId");
            DropColumn("dbo.Pessoa", "SyncId");
            DropColumn("dbo.Estabelecimento", "SyncId");
            DropColumn("dbo.Turma", "SyncId");
            DropColumn("dbo.Curso", "SyncId");
        }
    }
}
