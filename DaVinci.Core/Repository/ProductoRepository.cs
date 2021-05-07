using DaVinci.Core.Repository.Interface;
using DaVinci.DataBase.Context;
using DaVinci.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaVinci.Core.Repository
{
    public class ProductoRepository : IProducto
    {
        private readonly DaVinciContext _context;

        public ProductoRepository()
        {
            //_context = new DaVinciContext();  
        }
        ProductoRepository(DaVinciContext context ) {
            _context = context;
        }

        public void CrearProducto(ProductoModel producto)
        {

            using (var context = new DaVinciContext())
            {

                var data = new ProductoModel();
                data.Nombre =producto.Nombre;
                data.Referencia = producto.Referencia;
                data.Descripcion = producto.Descripcion;
                data.Valor = producto.Valor;
                
                var response = context.Producto.Add(data);
                            
                context.SaveChanges();
                producto.Id= data.Id;
            }

        }

        public void EditarProducto(ProductoModel producto)
        {
            using (var context = new DaVinciContext())
            {
                ProductoModel ProductoToEditar = context.Producto.Where(data => data.Id == producto.Id).FirstOrDefault();

                

                //ProductoToEditar.Id= producto.Id ;
                ProductoToEditar.Nombre = producto.Nombre;
                ProductoToEditar.Referencia = producto.Referencia;
                ProductoToEditar.Descripcion = producto.Descripcion;
                ProductoToEditar.Valor = producto.Valor;

                //var response = context.Producto.Add(data);

                context.SaveChanges();
            }
        }

        

        public ProductoModel ObtenerProducto(int id)
        {

            ProductoModel producto;
            using (var context = new DaVinciContext())
            {
               producto= context.Producto.Find(id);                
            }

            return producto;
            //throw new NotImplementedException();
        }

        public List<ProductoModel> ObtenerProductos()
        {
            List<ProductoModel> productos;
            using (var context = new DaVinciContext())
            {
                productos= context.Producto.ToList();
            }

            return productos;
        }


        public void EliminarProducto(int id)
        {
            using (var context = new DaVinciContext())
            {
                var ProductoToDelete = context.Producto.Where(data => data.Id == id).FirstOrDefault();

                context.Producto.Remove(ProductoToDelete);
                
                context.SaveChanges();
            }

        }


    }
}
