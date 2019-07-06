using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SamSystemWeb.Models;

namespace SamSystemWeb.Data
{
    public class DataContext : IdentityDbContext<AppUser>
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        #region Properties for DB
        public DbSet<Cargo> Cargos { get; set; }

        public DbSet<Colaborador> Colaboradores { get; set; }

        public DbSet<Nivel> Niveles { get; set; }

        public DbSet<Estado> Estados { get; set; }

        public DbSet<Maestro> Maestros { get; set; }

        public DbSet<Seccion> Secciones { get; set; }

        public DbSet<FormaDePago> FormasDePago { get; set; }//Acuerdos de pago

        public DbSet<Tutor> Tutores { get; set; }

        public DbSet<Proveedor> Proveedores { get; set; }

        public Articulo  Articulos { get; set; }

        public DbSet<Estudiante> Estudiantes { get; set; }

        public DbSet<Retencion> Retenciones { get; set; }

        public DbSet<DetalleRetencion> DetalleRetenciones { get; set; }

        public DbSet<TipoDePago> TiposDePagos { get; set; }//Membresias o retenciones

        public DbSet<Factura> Facturas { get; set; }

        


        #endregion

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
