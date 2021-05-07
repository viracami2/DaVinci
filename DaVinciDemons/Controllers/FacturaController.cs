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
    public class FacturaController : ControllerBase
    {



        [HttpGet("All")]
        public List<FacturaModel> Get()
        {
            return FacturaService.Intancia.GetFacturas();
        }


        [HttpGet]
        public FacturaModel Get(int id)
        {
            return FacturaService.Intancia.GetFactura(id);
        }

        [HttpPost]
        public void Post(FacturaModel factura)
        {
            FacturaService.Intancia.GuardarFactura(factura);
        }

        
        [HttpDelete]
        public void Delete(int id)
        {
            FacturaService.Intancia.EliminarFactura(id);
        }
    }
}
