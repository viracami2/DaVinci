using DaVinci.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DaVinci.Core.Repository.Interface
{
   interface IFactura
    {
        List<FacturaModel> ObtenerFacturas();
        FacturaModel ObtenerFactura(int id);

        void CrearFactura(FacturaModel factura);
        void EditarFactura(FacturaModel factura);
        void EliminarFactura(int id);

    }
}
