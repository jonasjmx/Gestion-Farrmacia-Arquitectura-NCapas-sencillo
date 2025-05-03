using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class ProductoDatos
    {
        public static ProductoEntidad CargarDatosProductoPorId(int id)
        {
            try
            {
                ProductoEntidad producto = new ProductoEntidad();
                Producto productoLINQ = new Producto();

                using (DataClasses1DataContext context = new DataClasses1DataContext())
                {
                    productoLINQ = context.Producto.FirstOrDefault(x => x.id == id);
                }
                producto.Id = productoLINQ.id;
                producto.NombreComercial = productoLINQ.nombreComercial;
                producto.NombreGenerico = productoLINQ.nombreGenerico;
                producto.Presentacion = productoLINQ.presentacion;
                producto.Precio = (decimal)productoLINQ.precio;
                producto.Stock = (int)productoLINQ.stock;

                return producto;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<ProductoEntidad> CargarDatosProductos()
        {
			try
			{
                List<ProductoEntidad> productos = new List<ProductoEntidad>();
                List<Producto> productosLINQ = new List<Producto>();
                using (DataClasses1DataContext context = new DataClasses1DataContext())
                {
                    var resultado = from p in context.Producto 
                                    select p;
                    productosLINQ = resultado.ToList();
                }

                foreach (var item in productosLINQ)
                {
                    productos.Add(new ProductoEntidad(item.id,item.nombreComercial,item.nombreGenerico, item.presentacion, (decimal)item.precio, (int)item.stock));
                }
                return productos;
            }
			catch (Exception)
			{
                return null;
			}
        }

        internal static void ActualizarStock(VentaDetalleEntidad ventaDetalle)
        {
            try
            {
                using (DataClasses1DataContext context = new DataClasses1DataContext())
                {
                    var productoLINQ = context.Producto.FirstOrDefault(x => x.id == ventaDetalle.IdProducto);

                    productoLINQ.stock -= ventaDetalle.Cantidad;
                    context.SubmitChanges();
                    return;
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
