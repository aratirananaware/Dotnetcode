﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication3.Models
{
    public partial class sampledbContext : DbContext
    {
        public sampledbContext()
        {
        }

        public sampledbContext(DbContextOptions<sampledbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Tblsample> Tblsamples { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-P4I9JKU;Initial Catalog=sampledb;Integrated Security=True\n");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("course");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Cname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cname");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("student");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Tblsample>(entity =>
            {
                entity.ToTable("tblsample");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Text)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("text");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
