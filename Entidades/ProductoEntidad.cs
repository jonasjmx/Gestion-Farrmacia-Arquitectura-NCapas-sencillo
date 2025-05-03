using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoEntidad
    {
        public int Id { get; set; }
        public string NombreComercial { get; set; }
        public string NombreGenerico { get; set; }
        public string Presentacion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        public ProductoEntidad()
        {
        }

        public ProductoEntidad(int id, string nombreComercial,
            string nombreGenerico, string presentacion, decimal precio, int stock)
        {
            Id = id;
            NombreComercial = nombreComercial;
            NombreGenerico = nombreGenerico;
            Presentacion = presentacion;
            Precio = precio;
            Stock = stock;
        }
    }
}
