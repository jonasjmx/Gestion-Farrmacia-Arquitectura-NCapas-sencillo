using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class FacturaEntidad
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Iva { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }

        private List<VentaDetalleEntidad> _listaVentaDetalle;

        public List<VentaDetalleEntidad> ListaVentaDetalle
        {
            get 
            { 
                if (_listaVentaDetalle == null)
                {
                    _listaVentaDetalle = new List<VentaDetalleEntidad>();
                }
                return _listaVentaDetalle; 
            }
            set { _listaVentaDetalle = value; }
        }

        public FacturaEntidad()
        {
        }

        public FacturaEntidad(int id, int idCliente, DateTime fechaVenta, decimal iva, decimal subtotal, decimal total)
        {
            Id = id;
            IdCliente = idCliente;
            FechaVenta = fechaVenta;
            Iva = iva;
            Subtotal = subtotal;
            Total = total;
        }
    }
}
