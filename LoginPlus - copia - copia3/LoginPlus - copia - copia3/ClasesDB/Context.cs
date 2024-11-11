using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Login.ClasesDB
{
    public class Context : DbContext
    {
        public Context() { } // Constructor sin parámetros

        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<PermisoRol> PermisoRol { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<OrdenPedido> OrdenPedidos { get; set; }
        public DbSet<OrdenProducto> OrdenProducto { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<TarjetaCredito> Tarjetas_Credito { get; set; }
        public DbSet<Direccion> Direccion { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<MetodoPago> MetodoPago { get; set; }
        public DbSet<VentaProducto> VentaProductos { get; set; }
        public DbSet<ComprobantePago> ComprobantePago { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Precio> Precios { get; set; }
        public DbSet<ProductoProveedor> ProductoProveedor { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Data Source=ALFARO\\SQLEXPRESS;Initial Catalog=SaludPlus_1;Integrated Security=True;TrustServerCertificate=True");

            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Productos>()
                .HasKey(p => p.ProductoID);  // Define la clave primaria

            modelBuilder.Entity<TarjetaCredito>()
        .HasKey(t => t.TarjetaID);

            modelBuilder.Entity<Venta>()
                .HasKey(v => v.VentasID);

            modelBuilder.Entity<Departamento>()
                .HasKey(d => d.DepartamentosID);

            modelBuilder.Entity<TarjetaCredito>()
                .HasKey(t => t.TarjetaID);

            modelBuilder.Entity<Direccion>()
                .HasKey(d => d.DireccionID);
            modelBuilder.Entity<OrdenPedido>()
                .HasKey(o => o.OrdenPedidosID);
            modelBuilder.Entity<Proveedor>()
                 .HasKey(p => p.ProveedorID);

            /*  seccion para relaciones, el motivo, mar de dudas :)*/

            // Configuración de Cliente y Direccion
            modelBuilder.Entity<Cliente>()
                .HasOne(c => c.Direccion)
                .WithMany(d => d.Clientes)
                .HasForeignKey(c => c.DireccionID)
                .HasConstraintName("FK__Clientes__Direcc__3E1D39E1")
                .OnDelete(DeleteBehavior.Restrict); // Opcional, para evitar eliminación en cascada

            // Configuración de Cliente y TarjetaCredito
            modelBuilder.Entity<Cliente>()
                .HasOne(c => c.TarjetaCredito)
                .WithMany(t => t.Clientes)
                .HasForeignKey(c => c.TarjetaID)
                .HasConstraintName("FK__Clientes__Tarjet__1DB06A4F")
                .OnDelete(DeleteBehavior.Restrict);

            // Configuración de Municipio
            modelBuilder.Entity<Municipio>()
                .HasOne(m => m.Departamento)
                .WithMany(d => d.Municipios)
                .HasForeignKey(m => m.DepartamentosID)
                .HasConstraintName("FK__Municipio__Depar__395884C4");

                    modelBuilder.Entity<Direccion>()
            .HasOne(d => d.Departamento)
            .WithMany()
            .HasForeignKey(d => d.DepartamentosID)
            .HasConstraintName("FK__Direccion__Depar__3C34F16F")
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProductoProveedor>()
       .HasOne(pp => pp.Proveedor)
       .WithMany() // Sin propiedad de navegación en Proveedor
       .HasForeignKey(pp => pp.ProveedorID);

       


        }
    }
}
