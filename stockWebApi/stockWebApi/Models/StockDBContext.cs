using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace stockWebApi.Models
{
    public partial class StockDBContext : DbContext
    {
        public StockDBContext()
        {
        }

        public StockDBContext(DbContextOptions<StockDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Stockprice> Stockprices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-P4I9JKU;Initial Catalog=StockDB;Integrated Security=True\n");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.CompanyCode)
                    .HasName("PK__company__223C17EC9EABCBDE");

                entity.ToTable("company");

                entity.Property(e => e.CompanyCode).HasColumnName("companyCode");

                entity.Property(e => e.CompanyCeo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("companyCeo");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("companyName");

                entity.Property(e => e.CompanyTurnover).HasColumnName("companyTurnover");

                entity.Property(e => e.CompanyWebsite)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("companyWebsite");

                entity.Property(e => e.StockExchange)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("stockExchange");
            });

            modelBuilder.Entity<Stockprice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("stockprice");

                entity.Property(e => e.Stockprice1)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stockprice");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
