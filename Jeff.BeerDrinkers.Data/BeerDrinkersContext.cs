using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Jeff.BeerDrinkers.Domain.Domain;
using Npgsql.EntityFrameworkCore.PostgreSQL;


#nullable disable

namespace Jeff.BeerDrinkers.Data
{
    public partial class BeerDrinkersContext : DbContext
    {
        public BeerDrinkersContext()
        {
        }

        public BeerDrinkersContext(DbContextOptions<BeerDrinkersContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BeerDrinker> BeerDrinkers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server=172.105.23.202;Port=5432;Database=BeerDrinkers;User Id=jeffbob;Password=fiji1848;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.UTF-8");

            modelBuilder.Entity<BeerDrinker>(entity =>
            {
                entity.ToTable("BeerDrinker");

                entity.Property(e => e.BeerDrinkerId)
                    .HasColumnName("BeerDrinker_id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.City).HasMaxLength(25);

                entity.Property(e => e.Name)
                    .HasMaxLength(15)
                    .HasColumnName("name");

                entity.Property(e => e.Beer)
                    .HasColumnName("Beer");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
