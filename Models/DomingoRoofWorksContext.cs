using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Domingo_Roof_Works.Models
{
    public partial class DomingoRoofWorksContext : DbContext
    {
        public DomingoRoofWorksContext()
        {
        }

        public DomingoRoofWorksContext(DbContextOptions<DomingoRoofWorksContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobEmployee> JobEmployees { get; set; }
        public virtual DbSet<JobMaterial> JobMaterials { get; set; }
        public virtual DbSet<JobType> JobTypes { get; set; }
        public virtual DbSet<Material> Materials { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=KIAAN;Database=DomingoRoofWorks;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId).ValueGeneratedNever();

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Surname).IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Surname).IsUnicode(false);
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.HasKey(e => e.JobCardNo)
                    .HasName("PK__Job__98F47524394F14B9");

                entity.Property(e => e.JobCardNo).ValueGeneratedNever();

                entity.Property(e => e.JobTypeId).IsUnicode(false);
            });

            modelBuilder.Entity<JobEmployee>(entity =>
            {
                entity.Property(e => e.EmployeeId).IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany()
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Job_Emplo__Emplo__30F848ED");

                entity.HasOne(d => d.JobCardNoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.JobCardNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Job_Emplo__JobCa__300424B4");
            });

            modelBuilder.Entity<JobMaterial>(entity =>
            {
                entity.HasOne(d => d.JobCardNoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.JobCardNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Job_Mater__JobCa__2D27B809");

                entity.HasOne(d => d.Material)
                    .WithMany()
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Job_Mater__Mater__2E1BDC42");
            });

            modelBuilder.Entity<JobType>(entity =>
            {
                entity.Property(e => e.JobTypeId).ValueGeneratedNever();

                entity.Property(e => e.JobType1).IsUnicode(false);
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.Property(e => e.MaterialId).ValueGeneratedNever();

                entity.Property(e => e.Description).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
