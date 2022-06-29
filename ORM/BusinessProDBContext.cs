using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ORM.Entities;
using ORM.SP;

namespace ORM
{
    public partial class BusinessProDBContext : DbContext
    {
        public BusinessProDBContext()
        {
        }

        public BusinessProDBContext(DbContextOptions<BusinessProDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Articulos> Articulos { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }

        public virtual DbSet<sp_lista_articulos_activos> sp_lista_articulos_activos { get; set; } // implementacion del stored procedure en el contexto de datos

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=001SW\\ONE; Database=BusinessProDB; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articulos>(entity =>
            {
                entity.HasKey(e => e.IdArticulo)
                    .HasName("PK__articulo__3F6E8288AA24D1B4");

                entity.ToTable("articulos");

                entity.Property(e => e.IdArticulo).HasColumnName("id_articulo");

                entity.Property(e => e.CodArticulo)
                    .HasColumnName("cod_articulo")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Costo)
                    .HasColumnName("costo")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.Articulos)
                    .HasForeignKey(d => d.IdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_proveedor_articulo");
            });

            modelBuilder.Entity<Proveedores>(entity =>
            {
                entity.HasKey(e => e.IdProveedor)
                    .HasName("PK__proveedo__8D3DFE28D3B897FB");

                entity.ToTable("proveedores");

                entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");

                entity.Property(e => e.Cedula)
                    .HasColumnName("cedula")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CodProveedor)
                    .HasColumnName("cod_proveedor")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public void actualizarProveedores(Proveedores _prov) // implementacion de actualizacion de los datos de las entidades 
        {
            this.Proveedores.Update(_prov);
        }

        public void actualizarArticulos(Articulos _arti) // implementacion de actualizacion de los datos de las entidades 
        {
            this.Articulos.Update(_arti);
        }
    }
}
