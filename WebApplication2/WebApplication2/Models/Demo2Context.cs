using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication2.Models
{
    public partial class Demo2Context : DbContext
    {
        public Demo2Context()
        {
        }

        public Demo2Context(DbContextOptions<Demo2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<StudentInfo> StudentInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-64NB844R;Initial Catalog=Demo2;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.Coursename)
                    .HasName("PK__course__E08EA557FEAD576B");

                entity.ToTable("course");

                entity.Property(e => e.Coursename)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("coursename");
            });

            modelBuilder.Entity<StudentInfo>(entity =>
            {
                entity.ToTable("StudentInfo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
