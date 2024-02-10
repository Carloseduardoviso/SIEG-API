using Adaptadores.Constantes;
using Adaptadores.Mapping;
using Dominio.Entidades;
using Dominio.Entidades.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Adaptadores.Context
{
    public class SiegContext : DbContext
    {
        public SiegContext(DbContextOptions<SiegContext> contextOptions) : base(contextOptions)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ControleEstoque> ControleEstoques { get; set; }
        public DbSet<EntradaDoProduto> EntradaDoProdutos { get; set; }
        public DbSet<Fornecedo> Fornecedores { get; set; }
        public DbSet<Iten> Itens { get; set; }
        public DbSet<Movimentacao> Movimentacoes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<SaidaDeProduto> SaidaDeProdutos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<VendaDeProduto> VendaDeProdutos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<SiegContext>()
            //  .HasNoKey();

            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(t => t.GetProperties()).Where(p => p.ClrType == typeof(string)))
            {
                property.SetColumnType(ColumnTypeConstantes.varchar250);
            }

            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ControleEstoqueMap());
            modelBuilder.ApplyConfiguration(new EntradaDoProdutoMap());
            modelBuilder.ApplyConfiguration(new FornecedorMap());
            modelBuilder.ApplyConfiguration(new ItenMap());
            modelBuilder.ApplyConfiguration(new MovimentacaoMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new SaidaDeProdutoMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new VendaDeProdutoMap());

            modelBuilder.Ignore<prmToolkit.NotificationPattern.Notification>();
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
