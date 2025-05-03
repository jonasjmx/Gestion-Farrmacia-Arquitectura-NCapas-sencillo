using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VentaDetalleProductoCabeceraEntidad
    {
        public int Id { get; set; }
        public string NombreComercial { get; set; }
        public string NombreGenerico { get; set; }
        public string Presentacion { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }

        public VentaDetalleProductoCabeceraEntidad(int id, string nombreComercial, string nombreGenerico, string presentacion, decimal precio, 
            int cantidad, decimal subtotal)
        {
            Id = id;
            NombreComercial = nombreComercial;
            NombreGenerico = nombreGenerico;
            Presentacion = presentacion;
            Precio = precio;
            Cantidad = cantidad;
            Subtotal = subtotal;
        }

        public VentaDetalleProductoCabeceraEntidad()
        {
        }
    }
}
