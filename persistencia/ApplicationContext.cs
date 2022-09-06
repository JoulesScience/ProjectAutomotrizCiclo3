using System;
using Dominio;
using Microsoft.EntityFrameworkCore;

namespace persistencia
{
    public class ApplicationContext: DbContext
    {
        private const string connectionString = @"Data Source=localhost\citadel;Initial Catalog=EjemploG23;Integrated Security=True;";
        public DbSet<Persona> personas {get; set;}

        public DbSet<Vehiculo> vehiculos {get; set;}

        public DbSet<Auto> autos {get; set;}

        public DbSet<Camioneta> camionetas {get; set;}

        public DbSet<Cliente> clientes {get; set;}

        public DbSet<Tecnico> tecnicos {get; set;}

        public DbSet<Factura> Facturas {get; set;}

        public ApplicationContext(){}

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        :base(options)
    {
    }

     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString);
    }

    }
}
