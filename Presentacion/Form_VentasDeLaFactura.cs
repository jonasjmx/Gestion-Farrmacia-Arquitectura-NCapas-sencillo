using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form_VentasDeLaFactura : Form
    {
        List<VentaDetalleProductoCabeceraEntidad> ventasCabecera = new List<VentaDetalleProductoCabeceraEntidad>();
        ClienteEntidad cliente = new ClienteEntidad();
        FacturaEntidad factura = new FacturaEntidad();
        public Form_VentasDeLaFactura(FacturaEntidad factura)
        {
            InitializeComponent();
            CargarFactura(factura);
            CargarDatosFactura();
            CargarVentasFactura();
        }

        private void CargarFactura(FacturaEntidad factura)
        {
            this.factura = factura;
        }

        private void CargarDatosFactura()
        {
            cliente = ClienteNegocio.BuscarClientePorId(Convert.ToInt32(factura.IdCliente));
            if (cliente == null)
                return;
            label__NumeroFactura.Text = factura.Id.ToString();
            label_CedulaCLiente.Text = cliente.Id.ToString();
            label_NombreCliente.Text = cliente.Nombre.ToString();
            label_ApellidoCliente.Text = cliente.Apellido.ToString();
        }

        private void CargarVentasFactura()
        {
            factura.ListaVentaDetalle = VentaDetalleNegocio.ObtenerListaVentaDetalle(factura.Id);
            if (factura.ListaVentaDetalle == null)
                return;
            ProductoEntidad producto = new ProductoEntidad();
            foreach (var ventaDetalle in factura.ListaVentaDetalle)
            {
                producto = ProductoNegocio.CargarDatosProductoPorId(ventaDetalle.IdProducto);
                ventasCabecera.Add(new VentaDetalleProductoCabeceraEntidad(
                    ventaDetalle.Id,
                    producto.NombreGenerico,
                    producto.NombreComercial,
                    producto.Presentacion,
                    producto.Precio,
                    ventaDetalle.Cantidad,
                    ventaDetalle.Subtotal
                    ));
            }
            dataGridView_VentasFactura.DataSource = ventasCabecera;
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            // Configurar las propiedades de la ventana de vista previa
            vistaPrevia.Width = Screen.PrimaryScreen.Bounds.Width; // Ancho de la pantalla
            vistaPrevia.Height = Screen.PrimaryScreen.Bounds.Height; // Alto de la pantalla
            vistaPrevia.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana
            vistaPrevia.WindowState = FormWindowState.Maximized; // Maximizar la ventana

            // Mostrar la ventana de vista previa
            vistaPrevia.ShowDialog();
        }

        private void ImprimirDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Pen penBlack = new Pen(Color.Black, 2);
            Rectangle rectangle = new Rectangle(0, 0, 600, 800);
            e.Graphics.DrawRectangle(penBlack, rectangle);

            Font fuenteCabezera = new Font("Calibri", 12, FontStyle.Bold);
            Font fuenteCabezera2 = new Font("Calibri", 10);
            Font fuenteCuerpo = new Font("Time New Roman", 8);


            int y = 5;

            e.Graphics.DrawString("FARMACIA GIRASOL", fuenteCabezera, Brushes.DarkGray, 250, y += 20);
            e.Graphics.DrawString("DETALLE DE LA VENTA", fuenteCabezera2, Brushes.DarkBlue, 250, y += 20);
            e.Graphics.DrawString("CLIENTE: " + cliente.Nombre, fuenteCuerpo, Brushes.Black, 20, y += 40);
            e.Graphics.DrawString("CEDULA: " + cliente.Cedula, fuenteCuerpo, Brushes.Black, 20, y += 40);
            e.Graphics.DrawString("TELEFONO: " + cliente.Telefono, fuenteCuerpo, Brushes.Black, 20, y += 40);
            e.Graphics.DrawString("CORREO: " + cliente.Correo, fuenteCuerpo, Brushes.Black, 20, y += 40);
            e.Graphics.DrawString("DIRECCION: " + cliente.Direccion, fuenteCuerpo, Brushes.Black, 20, y += 40);
            e.Graphics.DrawString("FECHA COMPROBANTE: " + factura.FechaVenta, fuenteCuerpo, Brushes.Black, 20, y += 40);

            y += 20;

            e.Graphics.DrawString("PRODUCTO", fuenteCuerpo, Brushes.Black, 20, y += 40);
            e.Graphics.DrawString("PRECIO UNITARIO", fuenteCuerpo, Brushes.Black, 250, y);
            e.Graphics.DrawString("CANTIDAD", fuenteCuerpo, Brushes.Black, 400, y);
            e.Graphics.DrawString("SUBTOTAL", fuenteCuerpo, Brushes.Black, 500, y);

            foreach (var item in ventasCabecera)
            {
                e.Graphics.DrawString(item.NombreComercial, fuenteCuerpo, Brushes.Black, 20, y += 40);
                e.Graphics.DrawString(item.Precio.ToString("0." +
                    "" +
                    "00"), fuenteCuerpo, Brushes.Black, 250, y);
                e.Graphics.DrawString(item.Cantidad.ToString(), fuenteCuerpo, Brushes.Black, 400, y);
                e.Graphics.DrawString(item.Subtotal.ToString("0.00"), fuenteCuerpo, Brushes.Black, 500, y);
            }

            y = 700;
            e.Graphics.DrawString("IVA: " + factura.Iva.ToString("0.00"), fuenteCuerpo, Brushes.Black, 20, y += 20);
            e.Graphics.DrawString("SUBTOTAL: " + factura.Subtotal.ToString("0.00"), fuenteCuerpo, Brushes.Black, 20, y += 20);
            e.Graphics.DrawString("TOTAL: " + factura.Total.ToString("0.00"), fuenteCuerpo, Brushes.Black, 20, y += 20);
        }
    }
}
