using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VentaDetalleEntidad
    {
        public int Id { get; set; }
        public int IdFactura { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }

        public VentaDetalleEntidad()
        {
        }

        public VentaDetalleEntidad(int id, int idFactura, int idProducto, int cantidad, decimal subtotal)
        {
            Id = id;
            IdFactura = idFactura;
            IdProducto = idProducto;
            Cantidad = cantidad;
            Subtotal = subtotal;
        }
    }
}
