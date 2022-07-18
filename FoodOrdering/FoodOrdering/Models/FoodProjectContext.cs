using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FoodOrdering.Models
{
    public partial class FoodProjectContext : DbContext
    {
        public FoodProjectContext()
        {
        }

        public FoodProjectContext(DbContextOptions<FoodProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<FoodDetail> FoodDetails { get; set; }
        public virtual DbSet<OrderTbl> OrderTbls { get; set; }
        public virtual DbSet<RegisterTbl> RegisterTbls { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-64NB844R;Initial Catalog=FoodProject;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CatId);

                entity.ToTable("Category");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.CatName).HasMaxLength(50);
            });

            modelBuilder.Entity<FoodDetail>(entity =>
            {
                entity.ToTable("FoodDetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.FoodDescription).HasMaxLength(50);

                entity.Property(e => e.FoodImage).HasMaxLength(50);

                entity.Property(e => e.FoodName).HasMaxLength(50);
            });

            modelBuilder.Entity<OrderTbl>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("OrderTbl");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.FoodName).HasMaxLength(50);

                entity.Property(e => e.PaymentMode).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<RegisterTbl>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("RegisterTbl");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
