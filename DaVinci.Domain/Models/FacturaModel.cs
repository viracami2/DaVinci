using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DaVinci.Domain.Models
{
    [Table("Factura")]
    public class FacturaModel
    {
        [Key]
        public int Id { get; set; }
        public decimal Nit { get; set; }
        public int NumeroFactura{ get; set; }

        public decimal ValorBruto { get; set; }
        public decimal Iva{ get; set; }
        public decimal ValorTotal { get; set; }
        public string Observacion { get; set; }
        [NotMapped]
        public List<DetalleFacturaModel>  DetallesFactura { get; set; }
    }
}
