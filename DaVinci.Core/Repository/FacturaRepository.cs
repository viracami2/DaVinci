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
    public class FacturaRepository : IFactura
    {
        private readonly DaVinciContext _context;

        public FacturaRepository()
        {
            //_context = new DaVinciContext();  
        }
        FacturaRepository(DaVinciContext context ) {
            _context = context;
        }

        public void CrearFactura(FacturaModel factura)
        {

            using (var context = new DaVinciContext())
            {


                
                var data = new FacturaModel();
                data.NumeroFactura=factura.NumeroFactura;
                data.Nit=factura.Nit;
                data.Observacion= factura.Observacion;
                data.ValorBruto= factura.ValorBruto;
                data.Iva= factura.Iva;
                data.ValorTotal = factura.ValorTotal;
                var response = context.Factura.Add(data);

            
                context.SaveChanges();
                factura.Id= data.Id;

                foreach (var detalle in factura.DetallesFactura)
                {
                    //producto.IdFactura = factura.Id;
                    //    var product = new DetalleFacturaModel() {IdFactura= factura.Id , IdProducto= producto.IdProducto };
                    var product = new DetalleFacturaModel();
                    product.IdFactura = factura.Id;
                    product.IdProducto = detalle.IdProducto;

                    context.DetalleFactura.Add(product);

                }
                context.SaveChanges();

                //toca crear una tabla que se llame
                //    detalle de factura


                //    donde van a ir guardados los productos 

            }

        }

        public void EditarFactura(FacturaModel factura)
        {
            throw new NotImplementedException();
        }

        public void EliminarFactura(int id)
        {
            using (var context = new DaVinciContext())
            {
                var DetalleFacturaToDelete = context.DetalleFactura.Where(data => data.IdFactura == id).ToList();

                   context.DetalleFactura.RemoveRange(DetalleFacturaToDelete);
                //foreach (var item in DetalleFacturaToDelete)
                //{
                //    context.DetalleFactura.Remove(item);
                //}
                var FacturaToDelete  = context.Factura.Where(data => data.Id== id).FirstOrDefault();

                context.Factura.Remove(FacturaToDelete);
                context.SaveChanges();
            }

        }

        public FacturaModel ObtenerFactura(int id)
        {

            FacturaModel factura;
            using (var context = new DaVinciContext())
            {


                var test  = context.Factura.Find(id);
                factura= context.Factura.Find(id);
                //context.SaveChanges();
            }

            return factura;
            //throw new NotImplementedException();
        }

        public List<FacturaModel> ObtenerFacturas()
        {
            List<FacturaModel> facturas;
            using (var context = new DaVinciContext())
            {
                facturas = context.Factura.ToList();
            }

            return facturas;

            
        }
    }
}
