using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DaVinci.Domain.Models
{
    public class DetalleFacturaModel
    {
        [Key]
        public int Id { get; set; }        
        public int IdFactura { get; set; }
        public int IdProducto { get; set; }

        
    }
}
