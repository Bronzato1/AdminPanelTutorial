using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CRUD_Operations.Models
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        { }

        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<Doctors> Doctors { get; set; }
        public virtual DbSet<Nurses> Nurses { get; set; }
        public virtual DbSet<Patients> Patients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Admins>(entity =>
                   {
                       entity
                            .ToTable("Admins", "dbo");

                       entity
                            .Property(e => e.Id)
                            .HasColumnName("Id");

                       entity
                            .Property(e => e.Created)
                            .HasColumnName("Created")
                            .HasDefaultValueSql("getdate()");

                       entity.Property(e => e.Email)
                           .IsRequired()
                           .HasColumnName("Email")
                           .HasMaxLength(255)
                           .IsUnicode(false);

                       entity.Property(e => e.Name)
                           .IsRequired()
                           .HasColumnName("Name")
                           .HasMaxLength(255)
                           .IsUnicode(false);

                       entity.Property(e => e.Password)
                           .IsRequired()
                           .HasColumnName("Password")
                           .HasMaxLength(255)
                           .IsUnicode(false);

                       entity.Property(e => e.Phone)
                           .IsRequired()
                           .HasColumnName("Phone")
                           .HasMaxLength(15)
                           .IsUnicode(false);
                   });

            modelBuilder.Entity<Doctors>(entity =>
            {
                entity
                    .ToTable("Doctors", "dbo");

                entity
                    .Property(e => e.Id)
                    .HasColumnName("Id");

                entity
                    .Property(e => e.Created)
                    .HasColumnName("Created")
                    .HasDefaultValueSql("getdate()");

                entity
                    .Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("Email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity
                    .Property(e => e.Gender)
                    .HasColumnName("Gender");

                entity
                    .Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("Name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity
                    .Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("Password")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity
                    .Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("Phone")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity
                    .Property(e => e.Specialist)
                    .IsRequired()
                    .HasColumnName("Specialist")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Nurses>(entity =>
            {
                entity
                    .ToTable("Nurses", "dbo");

                entity
                    .Property(e => e.Id)
                    .HasColumnName("id");

                entity
                    .Property(e => e.Created)
                    .HasColumnName("Created")
                    .HasDefaultValueSql("getdate()");

                entity
                    .Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("Email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity
                    .Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("Name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity
                    .Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("Password")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity
                    .Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("Phone")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Patients>(entity =>
            {
                entity
                    .ToTable("Patients", "dbo");

                entity
                    .HasIndex(e => e.DoctorId)
                    .HasName("doctor_id");

                entity
                    .HasIndex(e => e.NurseId)
                    .HasName("nurse_id");

                entity
                    .Property(e => e.Id)
                    .HasColumnName("Id");

                entity
                    .Property(e => e.Created)
                    .HasColumnName("Created")
                    .HasDefaultValueSql("getdate()");

                entity
                    .Property(e => e.DoctorId)
                    .HasColumnName("Doctor_id");

                entity
                    .Property(e => e.Gender)
                    .HasColumnName("Gender");

                entity
                    .Property(e => e.HealthCondition)
                    .IsRequired()
                    .HasColumnName("Health_condition")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity
                    .Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("Name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity
                    .Property(e => e.NurseId)
                    .HasColumnName("Nurse_id");

                entity
                    .Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("Phone")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity
                    .HasOne(d => d.Doctor)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("patients_ibfk_1");

                entity
                    .HasOne(d => d.Nurse)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.NurseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("patients_ibfk_2");
            });
        }
    }
}