using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DaVinci.Domain.Models
{
    public class ProductoModel
    {
        [Key]
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public string Nombre { get; set; }
        public string Referencia{ get; set; }
        public string Descripcion { get; set; }

    }
}
