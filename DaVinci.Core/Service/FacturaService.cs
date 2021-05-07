using DaVinci.Core.Repository;
using DaVinci.Domain.Models;
using System.Collections.Generic;

namespace DaVinci.Core.Service
{

    public class FacturaService
    {

        
        private static FacturaService instancia;
        private static FacturaRepository repo;
        public static FacturaService Intancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new FacturaService();
                    repo = new FacturaRepository();
                }
                return instancia;
            }
        }

        public FacturaModel GetFactura(int id) {

            return repo.ObtenerFactura(id); 
        }

        public List<FacturaModel> GetFacturas()
        {
            return repo.ObtenerFacturas();

        }

        public void GuardarFactura(FacturaModel factura)
        {
            repo.CrearFactura(factura);
        }

        public void EliminarFactura(int id)
        {
            repo.EliminarFactura(id);
        }

    }
}
