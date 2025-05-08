using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Datos
{
    public static class VentaDetalleDatos
    {
        public static List<VentaDetalleProductoCabeceraEntidad> ComprobarExistenciaProductos(List<VentaDetalleProductoCabeceraEntidad> listaCabecera)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    List<VentaDetalleProductoCabeceraEntidad> lista = ProductoDatos.ComprobarExistenciaProductos(listaCabecera);

                    if (lista == null || lista.Count == 0)
                        return null;

                    scope.Complete();
                    return lista;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static void Nuevo(VentaDetalleEntidad ventaDetalle)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    Venta_Detalle ventaDetalleLINQ = new Venta_Detalle
                    {
                        idFactura = ventaDetalle.IdFactura,
                        idProducto = ventaDetalle.IdProducto,
                        cantidad = ventaDetalle.Cantidad,
                        subtotal = ventaDetalle.Subtotal
                    };

                    using (DataClasses1DataContext context = new DataClasses1DataContext())
                    {
                        context.Venta_Detalle.InsertOnSubmit(ventaDetalleLINQ);
                        context.SubmitChanges();
                    }

                    scope.Complete();
                }
            }
            catch (Exception)
            {
                // Handle exception if needed
            }
        }

        public static List<VentaDetalleEntidad> ObtenerListaVentaDetalle(int idFactura)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
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

                    scope.Complete();
                    return ventas;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
