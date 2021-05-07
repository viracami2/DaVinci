using DaVinci.Core.Service;
using DaVinci.Domain.Models;
using NUnit.Framework;

namespace DaVinci.WhiteBox
{
    public class ProductoTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DeberiaCrearUnProducto()
        {
            var prod = new ProductoModel();
            prod.Nombre = "plato para la cocina";
            prod.Descripcion = "plato";
            prod.Referencia = "Co-6";
            prod.Valor= 3500;

            ProductoService.Intancia.GuardarProducto(prod);
            Assert.Pass();
        }
    }
}