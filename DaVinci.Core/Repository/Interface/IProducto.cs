using DaVinci.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DaVinci.Core.Repository.Interface
{
   interface IProducto
    {
        List<ProductoModel> ObtenerProductos();
        ProductoModel ObtenerProducto(int id);

        void CrearProducto(ProductoModel producto);
        void EditarProducto(ProductoModel  producto);
        void EliminarProducto(int id);

    }
}
