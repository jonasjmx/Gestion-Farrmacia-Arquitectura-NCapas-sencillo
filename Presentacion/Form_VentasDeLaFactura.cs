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

        private readonly List<VentaDetalleProductoCabeceraEntidad> listaCabecera = new List<VentaDetalleProductoCabeceraEntidad>();
        private readonly ClienteEntidad cliente = new ClienteEntidad();
        private readonly FacturaEntidad factura = new FacturaEntidad();

        public Form_VentasDeLaFactura(FacturaEntidad factura)
        {
            InitializeComponent();
            this.factura = factura;
            CargarDatosFactura();
            CargarVentasFactura();
        }

        private void CargarDatosFactura()
        {
            ClienteEntidad cliente = ClienteNegocio.BuscarClientePorId(Convert.ToInt32(factura.IdCliente));
            if (cliente == null)
                return;

            label__NumeroFactura.Text = factura.Id.ToString();
            label_CedulaCLiente.Text = cliente.Id.ToString();
            label_NombreCliente.Text = cliente.Nombre.ToString();
            label_ApellidoCliente.Text = cliente.Apellido.ToString();

            this.cliente.Id = cliente.Id;
            this.cliente.Nombre = cliente.Nombre;
            this.cliente.Apellido = cliente.Apellido;
            this.cliente.Cedula = cliente.Cedula;
            this.cliente.Telefono = cliente.Telefono;
            this.cliente.Correo = cliente.Correo;
            this.cliente.Direccion = cliente.Direccion;
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
                listaCabecera.Add(new VentaDetalleProductoCabeceraEntidad(
                    ventaDetalle.Id,
                    producto.NombreGenerico,
                    producto.NombreComercial,
                    producto.Presentacion,
                    producto.Precio,
                    ventaDetalle.Cantidad,
                    ventaDetalle.Subtotal
                    ));
            }
            dataGridView_VentasFactura.DataSource = listaCabecera;
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
            Font fuenteCabezera = new Font("Calibri", 14, FontStyle.Bold);
            Font fuenteCabezera2 = new Font("Calibri", 12);
            Font fuenteCuerpo = new Font("Time New Roman", 10);


            int y = 5;

            e.Graphics.DrawString("FARMACIA GIRASOL", fuenteCabezera, Brushes.DarkGray, 330, y += 20);
            e.Graphics.DrawString("DETALLE DE LA VENTA", fuenteCabezera2, Brushes.DarkBlue, 335, y += 20);
            
            e.Graphics.DrawString("NOMBRE CLIENTE: ", fuenteCuerpo, Brushes.Black, 20, y += 40);
            e.Graphics.DrawString(cliente.Nombre + cliente.Apellido, fuenteCuerpo, Brushes.Black, 200, y);
            
            e.Graphics.DrawString("CEDULA: ", fuenteCuerpo, Brushes.Black, 20, y += 40);
            e.Graphics.DrawString(cliente.Cedula, fuenteCuerpo, Brushes.Black, 200, y);

            e.Graphics.DrawString("TELEFONO: ", fuenteCuerpo, Brushes.Black, 20, y += 40);
            e.Graphics.DrawString(cliente.Telefono, fuenteCuerpo, Brushes.Black, 200, y);

            e.Graphics.DrawString("CORREO: ", fuenteCuerpo, Brushes.Black, 20, y += 40);
            e.Graphics.DrawString(cliente.Correo, fuenteCuerpo, Brushes.Black, 200, y);

            e.Graphics.DrawString("DIRECCION: ", fuenteCuerpo, Brushes.Black, 20, y += 40);
            e.Graphics.DrawString(cliente.Direccion, fuenteCuerpo, Brushes.Black, 200, y);

            e.Graphics.DrawString("FECHA COMPROBANTE: ", fuenteCuerpo, Brushes.Black, 20, y += 40);
            e.Graphics.DrawString(factura.FechaVenta + "", fuenteCuerpo, Brushes.Black, 200, y);

            y += 20;

            e.Graphics.DrawString("PRODUCTO", fuenteCuerpo, Brushes.Black, 20, y += 40);
            e.Graphics.DrawString("PRECIO UNITARIO", fuenteCuerpo, Brushes.Black, 350, y);
            e.Graphics.DrawString("CANTIDAD", fuenteCuerpo, Brushes.Black, 550, y);
            e.Graphics.DrawString("SUBTOTAL", fuenteCuerpo, Brushes.Black, 700, y);

            foreach (var item in listaCabecera)
            {
                e.Graphics.DrawString(item.NombreComercial, fuenteCuerpo, Brushes.Black, 20, y += 40);
                e.Graphics.DrawString(item.Precio.ToString("0." +
                    "" +
                    "00"), fuenteCuerpo, Brushes.Black, 350, y);
                e.Graphics.DrawString(item.Cantidad.ToString(), fuenteCuerpo, Brushes.Black, 550, y);
                e.Graphics.DrawString(item.Subtotal.ToString("0.00"), fuenteCuerpo, Brushes.Black, 700, y);
            }

            y = 1000;
            e.Graphics.DrawString("IVA: ", fuenteCuerpo, Brushes.Black, 20, y += 20);
            e.Graphics.DrawString(factura.Iva.ToString("0.00"), fuenteCuerpo, Brushes.Black, 200, y);
            e.Graphics.DrawString("SUBTOTAL: ", fuenteCuerpo, Brushes.Black, 20, y += 20);
            e.Graphics.DrawString(factura.Subtotal.ToString("0.00"), fuenteCuerpo, Brushes.Black, 200, y);
            e.Graphics.DrawString("TOTAL: ", fuenteCuerpo, Brushes.Black, 20, y += 20);
            e.Graphics.DrawString(factura.Total.ToString("0.00"), fuenteCuerpo, Brushes.Black, 200, y);
        }

        private void Form_VentasDeLaFactura_Load(object sender, EventArgs e)
        {
            dataGridView_VentasFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
