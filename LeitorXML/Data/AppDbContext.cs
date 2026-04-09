using LeitorXML.Models;
using Microsoft.EntityFrameworkCore;

namespace LeitorXML.Data
{
    public class AppDbContext : DbContext
    {
        private const string DefaultConnectionString =
            "Server=localhost;Database=LeitorXmlDb;User ID=sa;Password=sa123;TrustServerCertificate=True;";

        public DbSet<NotaFiscal> NotasFiscais => Set<NotaFiscal>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
            {
                return;
            }

            string connectionString =
                Environment.GetEnvironmentVariable("LEITORXML_SQLSERVER_CONNECTION")
                ?? DefaultConnectionString;

            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NotaFiscal>(entity =>
            {
                entity.ToTable("NotasFiscais");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Numero).HasMaxLength(30);
                entity.Property(e => e.Serie).HasMaxLength(20);
                entity.Property(e => e.DataEmissao).HasMaxLength(50);
                entity.Property(e => e.ValorTotal).HasMaxLength(30);
                entity.Property(e => e.Emitente).HasMaxLength(200);
                entity.Property(e => e.CnpjEmitente).HasMaxLength(20);
                entity.Property(e => e.ChaveAcesso).HasMaxLength(60).IsRequired();
                entity.HasIndex(e => e.ChaveAcesso).IsUnique();
            });
        }
    }
}
