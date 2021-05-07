using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DaVinci.Core.Service;
using DaVinci.DataBase.Context;
using DaVinci.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DaVinciDemons.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoController : ControllerBase
    {



        [HttpGet]
        public ProductoModel Get(int id)
        {
            return ProductoService.Intancia.GetProducto(id);
        }

        [HttpGet("Todos")]
        public List<ProductoModel> Get()
        {
            return ProductoService.Intancia.GetProducto();
        }


        [HttpPost("Crear")]
        public void Post(ProductoModel producto)
        {
            ProductoService.Intancia.GuardarProducto(producto);
        }

        [HttpPost("Editar")]
        public void Editar(ProductoModel producto)
        {
            ProductoService.Intancia.EditarProducto(producto);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            ProductoService.Intancia.EliminarProducto(id);
        }

    }
}
