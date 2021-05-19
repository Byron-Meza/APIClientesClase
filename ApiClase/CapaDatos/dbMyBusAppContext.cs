using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Entidades;

#nullable disable

namespace CapaDatos
{
    public partial class dbMyBusAppContext : DbContext
    {
        public dbMyBusAppContext()
        {
        }

        public dbMyBusAppContext(DbContextOptions<dbMyBusAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ClientesPersona> ClientesPersonas { get; set; }
        public virtual DbSet<TbCliente> TbClientes { get; set; }
        public virtual DbSet<TbPersona> TbPersonas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=dbMyBusApp;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<ClientesPersona>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClientesPersona");

                entity.Property(e => e.FechaNac)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaNac");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("id")
                    .IsFixedLength(true);

                entity.Property(e => e.Membresia).HasColumnName("membresia");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("nombre")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TbCliente>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.TipoId });

                entity.ToTable("tbClientes");

                entity.Property(e => e.Id)
                    .HasMaxLength(12)
                    .HasColumnName("id")
                    .IsFixedLength(true);

                entity.Property(e => e.TipoId).HasColumnName("tipoId");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Membresia).HasColumnName("membresia");

                entity.Property(e => e.TipoCliente).HasColumnName("tipoCliente");

                entity.HasOne(d => d.TbPersona)
                    .WithOne(p => p.TbCliente)
                    .HasForeignKey<TbCliente>(d => new { d.Id, d.TipoId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbClientes_tbPersonas1");
            });

            modelBuilder.Entity<TbPersona>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.TipoId });

                entity.ToTable("tbPersonas");

                entity.Property(e => e.Id)
                    .HasMaxLength(12)
                    .HasColumnName("id")
                    .IsFixedLength(true);

                entity.Property(e => e.TipoId).HasColumnName("tipoId");

                entity.Property(e => e.Apellido1)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("apellido1")
                    .IsFixedLength(true);

                entity.Property(e => e.Apellido2)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("apellido2")
                    .IsFixedLength(true);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("direccion")
                    .IsFixedLength(true);

                entity.Property(e => e.FechaNac)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaNac");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("nombre")
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
