using Ipme.Hometraining.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ipme.Hometraining.Persistance
{
    public class SqlDbContext : DbContext
    {
        private string ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=hometrainingbb;Trusted_Connection=True;MultipleActiveResultSets=true";
                
        public DbSet<ExerciceEntity> Exercices { get; set; }
        public DbSet<ProgramEntity> Programmes { get; set; }
        public DbSet<ProgramExerciceEntity> ProgrammesExercices { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {
        }

        public override DbSet<TEntity> Set<TEntity>()
        {
            ChangeTracker.LazyLoadingEnabled = false;
            ChangeTracker.AutoDetectChangesEnabled = false;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            return base.Set<TEntity>();
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(ConnectionString);

    }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProgramExerciceEntity>()
                .HasOne(p => p.Program)
                .WithMany(p => p.ProgramExercices)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }

}
