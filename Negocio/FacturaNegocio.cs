using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class FacturaNegocio
    {
        public static int DevolverNumeroUltimoComprobante()
        {
            return FacturaDatos.DevolverNumeroUltimoComprobante();
        }

        public static bool Guardar(FacturaEntidad factura)
        {
            return FacturaDatos.Nuevo(factura);
        }
    }
}
