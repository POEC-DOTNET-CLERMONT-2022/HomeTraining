using Ipme.Hometraining.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ipme.Hometraining.Persistance
{
    public class SqlDbContext : DbContext
    {
        //private string ConnectionString { get; }
                

        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {
        }

        public DbSet<ExerciceEntity> Exercices { get; set; }
        public DbSet<ProgramEntity> Programmes { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public override DbSet<TEntity> Set<TEntity>()
        {
            ChangeTracker.LazyLoadingEnabled = false;
            ChangeTracker.AutoDetectChangesEnabled = false;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            return base.Set<TEntity>();
        }



        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(ConnectionString);
        }*/

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExerciceEntity>().ToTable("Exercice");
           
        }*/
            
        //modelBuilder.Entity<ExerciceEntity>().ToTable("Exercice");
        //EntityTypeBuilder<ExerciceEntity> entityTypeBuilder = modelBuilder.Entity<ExerciceEntity>();

        //[Column("Pseudo")] //Si nom de colonne différent
        //entityTypeBuilder.Property(u => u.Login).HasColumnName("Pseudo");

        //si pas de clé
        //entityTypeBuilder.HasNoKey();

        //équivalent à [Table("User")] dans le SqlDto
        //entityTypeBuilder.ToTable("User");

        //équivalent à [Key] dans le SqlDto
        //userCatalog.HasKey(u => u.UserId);
    }

}
