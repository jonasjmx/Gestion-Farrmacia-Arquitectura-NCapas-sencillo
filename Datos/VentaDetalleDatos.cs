using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class VentaDetalleDatos
    {
        public static void Nuevo(VentaDetalleEntidad ventaDetalle)
        {
            try
            {
                Venta_Detalle ventaDetalleLINQ = new Venta_Detalle();

                ventaDetalleLINQ.idFactura = ventaDetalle.IdFactura;
                ventaDetalleLINQ.idProducto = ventaDetalle.IdProducto;
                ventaDetalleLINQ.cantidad = ventaDetalle.Cantidad;
                ventaDetalleLINQ.subtotal = ventaDetalle.Subtotal;

                using (DataClasses1DataContext context = new DataClasses1DataContext())
                {
                    context.Venta_Detalle.InsertOnSubmit(ventaDetalleLINQ);
                    context.SubmitChanges();
                }

                return;
            }
            catch (Exception)
            {
                return;
            }
        }

        public static List<VentaDetalleEntidad> ObtenerListaVentaDetalle(int idFactura)
        {
            try
            {
                List<VentaDetalleEntidad> ventas = new List<VentaDetalleEntidad>();
                using (DataClasses1DataContext context = new DataClasses1DataContext())
                {
                    var ListaVentasLINQ = context.Venta_Detalle.Where(x => x.idFactura == idFactura);

                    if (ListaVentasLINQ == null)
                        return null;

                    foreach (var venta_DetalleLINQ in ListaVentasLINQ)
                    {
                        ventas.Add(new VentaDetalleEntidad(
                            venta_DetalleLINQ.id,
                            (int)venta_DetalleLINQ.idFactura,
                            (int)venta_DetalleLINQ.idProducto,
                            (int)venta_DetalleLINQ.cantidad,
                            (decimal)venta_DetalleLINQ.subtotal
                            ));
                    }
                }
                return ventas;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
