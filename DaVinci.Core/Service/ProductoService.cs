using DaVinci.Core.Repository;
using DaVinci.Domain.Models;
using System.Collections.Generic;

namespace DaVinci.Core.Service
{

    public class ProductoService
    {

        
        private static ProductoService instancia;
        private static ProductoRepository repo;
        public static ProductoService Intancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ProductoService();
                    repo = new ProductoRepository();
                }
                return instancia;
            }
        }

        public ProductoModel GetProducto(int id) {

            return repo.ObtenerProducto(id); 
        }

        public List<ProductoModel> GetProducto()
        {

            return repo.ObtenerProductos();
        }

        public void GuardarProducto(ProductoModel producto)
        {
            repo.CrearProducto(producto);
        }

        public void EditarProducto(ProductoModel producto)
        {
            repo.EditarProducto(producto);
        }

        public void EliminarProducto(int id)
        {
            repo.EliminarProducto(id);
        }

    }
}
