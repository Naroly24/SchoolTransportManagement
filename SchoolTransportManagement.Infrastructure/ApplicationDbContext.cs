using Microsoft.EntityFrameworkCore;
using SchoolTransportManagement.Domain;

namespace SchoolTransportManagement.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Ruta> Rutas { get; set; }
        public DbSet<Conductor> Conductores { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Pago> Pagos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pago>(entity =>
            {
                entity.Property(e => e.Monto).HasColumnType("decimal(18,2)");
            });
        }
    }
}
