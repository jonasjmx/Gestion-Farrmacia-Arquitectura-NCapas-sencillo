using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

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
                using (TransactionScope scope = new TransactionScope())
                {
                    using (DataClasses1DataContext context = new DataClasses1DataContext())
                    {
                        productoLINQ = context.Producto.FirstOrDefault(x => x.id == id);
                    }
                    scope.Complete();
                }
                if (productoLINQ == null)
                    return null;
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
                using (TransactionScope scope = new TransactionScope())
                {
                    using (DataClasses1DataContext context = new DataClasses1DataContext())
                    {
                        var resultado = from p in context.Producto
                                        select p;
                        productosLINQ = resultado.ToList();
                    }
                    scope.Complete();
                }

                foreach (var item in productosLINQ)
                {
                    productos.Add(new ProductoEntidad(item.id, item.nombreComercial, item.nombreGenerico, item.presentacion, (decimal)item.precio, (int)item.stock));
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
                using (TransactionScope scope = new TransactionScope())
                {
                    using (DataClasses1DataContext context = new DataClasses1DataContext())
                    {
                        var productoLINQ = context.Producto.FirstOrDefault(x => x.id == ventaDetalle.IdProducto);

                        productoLINQ.stock -= ventaDetalle.Cantidad;
                        context.SubmitChanges();
                    }
                    scope.Complete();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        internal static List<VentaDetalleProductoCabeceraEntidad> ComprobarExistenciaProductos(List<VentaDetalleProductoCabeceraEntidad> listaCabecera)
        {
            try
            {
                List<VentaDetalleProductoCabeceraEntidad> lista = new List<VentaDetalleProductoCabeceraEntidad>();
                using (TransactionScope scope = new TransactionScope())
                {
                    using (DataClasses1DataContext context = new DataClasses1DataContext())
                    {
                        List<Producto> listaProductosLINQ = new List<Producto>();
                        // Me traigo la lista de productos de la BD
                        listaProductosLINQ = context.Producto.ToList();

                        foreach (var item in listaCabecera)
                        {
                            // compruebo si el id del producto no existe en la lista
                            if (!listaProductosLINQ.Exists(x => x.id == item.Id))
                                lista.Add(item);
                        }
                    }
                    scope.Complete();
                }
                if (lista.Count == 0)
                    return null;
                else
                    return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
