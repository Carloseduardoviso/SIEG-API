using Dominio.Entidades.Base;
using Microsoft.EntityFrameworkCore;

namespace Adaptadores.Context
{
    public class SiegContext : DbContext
    {
        public SiegContext(DbContextOptions<SiegContext> contextOptions) : base(contextOptions)
        {
        }

        //public DbSet<Produto> Produtos {  get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            AlterarPropriedadeDaClasse(EntityState.Added, nameof(Entidade.DataDeCriacao));
            AlterarPropriedadeDaClasse(EntityState.Modified, nameof(Entidade.DataDeAlteracao));

            return base.SaveChangesAsync(cancellationToken);
        }

        private void AlterarPropriedadeDaClasse(EntityState entityState, string entityName)
        {
            var entries = ChangeTracker.Entries().Where(x => x.State == entityState);

            foreach (var entityEntry in entries)
            {
                foreach (var propertyEntry in entityEntry.Properties)
                {
                    if (propertyEntry.Metadata.Name == entityName)
                    {
                        propertyEntry.CurrentValue = DateTime.Now;
                    }
                }
            }
        }
    }
}
