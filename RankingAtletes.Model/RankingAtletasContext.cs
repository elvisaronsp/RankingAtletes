using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Threading;

namespace RankingAtletes.Model
{
    public interface IContext
    {
        IDbSet<Atleta> Atletas { get; set; }
        IDbSet<Prueba> Pruebas { get; set; }
        IDbSet<Genero> Generos { get; set; }
        IDbSet<Marca> Marcas { get; set; }
        IDbSet<Medida> Medidas { get; set; }
        IDbSet<Pista> Pistas { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        int SaveChanges();
    }
    public class RankingAtletasContext : DbContext, IContext
    {
        public RankingAtletasContext() 
            : base("Name=RankingAtletasContext") { }

        public IDbSet<Atleta> Atletas { get; set; }
        public IDbSet<Prueba> Pruebas { get; set; }
        public IDbSet<Genero> Generos { get; set; }
        public IDbSet<Marca> Marcas { get; set; }
        public IDbSet<Medida> Medidas { get; set; }
        public IDbSet<Pista> Pistas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            var modifiedEntries = ChangeTracker.Entries()
                .Where(x => x.Entity is IAuditableEntity
                    && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entry in modifiedEntries)
            {
                IAuditableEntity entity = entry.Entity as IAuditableEntity;
                if (entity != null)
                {
                    string identityName = Thread.CurrentPrincipal.Identity.Name;
                    DateTime now = DateTime.UtcNow;

                    if (entry.State == EntityState.Added)
                    {
                        entity.CreadoPor = identityName;
                        entity.FechaCreacion = now;
                    }
                    else
                    {
                        Entry(entity).Property(x => x.CreadoPor).IsModified = false;
                        Entry(entity).Property(x => x.FechaCreacion).IsModified = false;
                    }

                    entity.ActualizadoPor = identityName;
                    entity.FechaActualizacion = now;
                }
            }

            return base.SaveChanges();
        }

    }
}
