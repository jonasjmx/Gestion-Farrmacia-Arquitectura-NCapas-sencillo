using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class FacturaDatos
    {
        public static int DevolverNumeroUltimoComprobante()
        {
			try
			{
				using (DataClasses1DataContext context = new DataClasses1DataContext())
				{
					int resultado = context.Factura.Count();
					return resultado + 1;
				}
			}
			catch (Exception)
			{
				return -1;
			}
        }

        public static bool Nuevo(FacturaEntidad factura)
        {
			try
			{
				Factura facturaLINQ = new Factura();

				facturaLINQ.idCliente = factura.IdCliente;
				facturaLINQ.iva = factura.Iva;
				facturaLINQ.subtotal = factura.Subtotal;
				facturaLINQ.Total = factura.Total;
				facturaLINQ.fechaVenta = factura.FechaVenta;

				using (DataClasses1DataContext context = new DataClasses1DataContext())
				{
					context.Factura.InsertOnSubmit(facturaLINQ);
					context.SubmitChanges();
				}

                foreach (var ventaDetalle in factura.ListaVentaDetalle)
                {
					ventaDetalle.IdFactura = facturaLINQ.id;
                    VentaDetalleDatos.Nuevo(ventaDetalle);
					ProductoDatos.ActualizarStock(ventaDetalle);
                }

                return true;
			}
			catch (Exception)
			{
				return false;
			}
        }

        internal static List<FacturaEntidad> DevolverFacturasCliente(int id)
        {
			try
			{
                List<FacturaEntidad> facturas = new List<FacturaEntidad>();
                using (DataClasses1DataContext context = new DataClasses1DataContext())
                {
                    var listaFacturasLINQ = context.Factura.Where(x => x.idCliente == id);

                    if (listaFacturasLINQ == null || listaFacturasLINQ.Count() == 0)
                        return null;

                    foreach (var facturaLINQ in listaFacturasLINQ)
                    {
                        facturas.Add(new FacturaEntidad(
                            facturaLINQ.id,
                            (int)facturaLINQ.idCliente,
                            (DateTime)facturaLINQ.fechaVenta,
                            (decimal)facturaLINQ.iva,
                            (decimal)facturaLINQ.subtotal,
                            (decimal)facturaLINQ.Total
                            ));
                    }
                }
				return facturas;
            }
			catch (Exception)
			{
				return null;
			}
        }
    }
}
