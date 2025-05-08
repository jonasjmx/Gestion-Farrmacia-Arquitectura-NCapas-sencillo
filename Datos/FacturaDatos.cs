using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

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
                using (TransactionScope scope = new TransactionScope())
                {
                    Factura facturaLINQ = new Factura
                    {
                        idCliente = factura.IdCliente,
                        iva = factura.Iva,
                        subtotal = factura.Subtotal,
                        Total = factura.Total,
                        fechaVenta = factura.FechaVenta
                    };

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

                    scope.Complete();
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
                using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
                {
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

                    scope.Complete();
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
