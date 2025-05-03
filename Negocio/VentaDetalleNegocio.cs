using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class VentaDetalleNegocio
    {
        public static List<VentaDetalleEntidad> ObtenerListaVentaDetalle(int idFactura)
        {
            return VentaDetalleDatos.ObtenerListaVentaDetalle(idFactura);
        }
    }
}
