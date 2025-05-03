using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class ProductoNegocio
    {
        public static ProductoEntidad CargarDatosProductoPorId(int id)
        {
            return ProductoDatos.CargarDatosProductoPorId(id);
        }

        public static List<ProductoEntidad> CargarDatosProductos()
        {
            return ProductoDatos.CargarDatosProductos();
        }
    }
}
