

using Domain.DGA.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.DGA.Context
{
    public class Project1DbContext : DbContext
    {
        public Project1DbContext(DbContextOptions<Project1DbContext> options) : base(options) {}

        public DbSet<Cliente> Clientes => Set<Cliente>();
        public DbSet<Producto> Productos => Set<Producto>();
        public DbSet<Venta> Ventas => Set<Venta>();
    }
}
