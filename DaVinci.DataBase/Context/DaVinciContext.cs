using DaVinci.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
//using Microsoft.EntityFrameworkCore;

namespace DaVinci.DataBase.Context
{
    public class DaVinciContext : DbContext
    {

        public DaVinciContext(DbContextOptions<DaVinciContext> contextOptions) :base(contextOptions)       { }
        public DaVinciContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //En caso de que el contexto no este configurado, lo configuramos mediante la cadena de conexion
            if (!optionsBuilder.IsConfigured)
            {
                
                optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS2016;Initial Catalog=DaVinci;Integrated Security=True", builder =>
                {
                    builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
                });
                base.OnConfiguring(optionsBuilder);
            }
        }

        public DbSet<FacturaModel> Factura { get; set; }
        public DbSet<DetalleFacturaModel> DetalleFactura { get; set; }
        public DbSet<ProductoModel> Producto { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FacturaModel>().ToTable("Factura");
            modelBuilder.Entity<DetalleFacturaModel>().ToTable("DetalleFactura");
            modelBuilder.Entity<ProductoModel>().ToTable("Producto");

        }

    }
}
