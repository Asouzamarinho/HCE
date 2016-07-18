using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Cruzeiro.Core.Model.Context
{
    public class CruzeiroContext : DbContext
    {
        public DbSet<Estabelecimento> Estabelecimentos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<EventoPortal> EventoPortals { get; set; }
        public DbSet<RegraPortal> RegraPortals { get; set; }
        public DbSet<ReaderConfig> ReaderConfigs { get; set; }
        public DbSet<TipoPessoa> TipoPessoas { get; set; }
        public DbSet<Leitor> Leitors { get; set; }

        public CruzeiroContext()
            : this("CruzeiroPortal")
        {
        }

        public CruzeiroContext(string dbName)
            : base(dbName)
        {
            Database.SetInitializer(new CruzeiroContextInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}