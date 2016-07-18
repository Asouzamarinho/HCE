namespace Cruzeiro.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Leitor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Leitor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LeitorId = c.Int(nullable: false),
                        Address = c.String(),
                        AntennasIn = c.String(),
                        AntennasOut = c.String(),
                        Name = c.String(),
                        LastChange = c.DateTime(nullable: false),
                        SyncId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Leitor");
        }
    }
}
