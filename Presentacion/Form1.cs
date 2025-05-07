using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{

    public partial class Form1 : Form
    {
        // Entidades inportantes para la factura
        ClienteEntidad cliente = new ClienteEntidad();
        FacturaEntidad factura = new FacturaEntidad();

        // Solo es para visualizar los datos de la venta en la tabla
        List<VentaDetalleProductoCabeceraEntidad> listaCabecera = new List<VentaDetalleProductoCabeceraEntidad>();
        public Form1()
        {
            InitializeComponent();
            UltimoNumeroComprobante();
        }

        private void UltimoNumeroComprobante()
        {
            int numeroComrpobante = FacturaNegocio.DevolverNumeroUltimoComprobante();
            textBox_Comprobante.Text = numeroComrpobante.ToString();
        }

        private void pictureBox_BuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                cliente = ClienteNegocio.BuscarClientePorCedula(textBox_Cedula.Text);

                if (cliente != null)
                {
                    textBox_Nombre.Text = cliente.Nombre;
                    textBox_Apellido.Text = cliente.Apellido;
                    textBox_Cedula.Text = cliente.Cedula;
                    textBox_Direccion.Text = cliente.Direccion;
                    textBox_Correo.Text = cliente.Correo;
                    textBox_Telefono.Text = cliente.Telefono;
                }
                else
                {
                    MessageBox.Show("No se encontro coincidencias", "Buscar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCamposCliente();
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        
        private void button_Productos_Click(object sender, EventArgs e)
        {
            using (Formulario_Productos formulario_Productos = new Formulario_Productos())
            {
                formulario_Productos.ShowDialog();
                ProductoEntidad producto = formulario_Productos.producto;
                if (producto != null)
                {
                    textBox_NombreComercial.Text = producto.NombreComercial;
                    textBox_NombreGenerico.Text = producto.NombreGenerico;
                    textBox_Presentacion.Text = producto.Presentacion;
                    textBox_Precio.Text = producto.Precio.ToString();
                    textBox_IdProducto.Text = producto.Id.ToString();
                }
            }
        }

        private void button_Agregar_Click(object sender, EventArgs e)
        {
            if ((textBox_Cantidad.Text != "" && Convert.ToInt32(textBox_Cantidad.Text) != 0) && textBox_IdProducto.Text != "")
                agregarVentaDetalleFactura();
            else
                MessageBox.Show("Error, agrega correctamente los datos necesarios","Tabla de venta Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void agregarVentaDetalleFactura()
        {
            VentaDetalleEntidad ventaDetalle = new VentaDetalleEntidad();

            ventaDetalle.IdProducto = Convert.ToInt32(textBox_IdProducto.Text);
            ventaDetalle.Cantidad = Convert.ToInt32(textBox_Cantidad.Text);
            //ventaDetalle.IdFactura = Convert.ToInt32(textBox_Comprobante.Text);
            decimal precio = Convert.ToDecimal(textBox_Precio.Text);
            ventaDetalle.Subtotal = precio * ventaDetalle.Cantidad;

            GuardarVentaDetalle(ventaDetalle);
            calcularTotalYSubtotal();
            cargarListaVentaDetalle();
        }

        private void calcularTotalYSubtotal()
        {
            decimal total = 0, subtotal = 0;
            decimal ivaSubtotal = 0;
            factura.ListaVentaDetalle.ForEach(ventaDetalle => {subtotal += ventaDetalle.Subtotal;});
            ivaSubtotal = subtotal * (Properties.Settings.Default.iva);
            total = subtotal + ivaSubtotal;

            textBox_IVA.Text = ivaSubtotal.ToString("F2");
            textBox_Subtotal.Text = subtotal.ToString("F2");
            textBox_Total.Text = total.ToString("F2");
        }

        private void cargarListaVentaDetalle()
        {
            dataGridViewDetalle_Venta.DataSource = listaCabecera.ToList();
        }

        private void GuardarVentaDetalle(VentaDetalleEntidad ventaDetalle)
        {
            ProductoEntidad producto = ProductoNegocio.CargarDatosProductoPorId(ventaDetalle.IdProducto);

            if (ventaDetalle.Cantidad > producto.Stock)
            {
                MessageBox.Show("Excede el Stock de este Producto", "Limite de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ComprobarSiEsNuevaVenta(ventaDetalle))
            {
                factura.ListaVentaDetalle.Add(ventaDetalle);
                listaCabecera.Add(new VentaDetalleProductoCabeceraEntidad(
                    ventaDetalle.IdProducto,
                    textBox_NombreComercial.Text,
                    textBox_NombreGenerico.Text,
                    textBox_Presentacion.Text,
                    (ventaDetalle.Subtotal/ventaDetalle.Cantidad),
                    ventaDetalle.Cantidad,
                    ventaDetalle.Subtotal
                    ));
                return;
            }
            if (ActualizarListaVentaDetalle(ventaDetalle, producto.Stock))
                return;
            else
                MessageBox.Show("Excede el Stock de este Producto", "Limite de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ActualizarListaVentaDetalle(VentaDetalleEntidad ventaDetalle, int stock)
        {
            foreach (var item in factura.ListaVentaDetalle)
            {
                if (item.IdProducto == ventaDetalle.IdProducto)
                {
                    if ((item.Cantidad + ventaDetalle.Cantidad) > stock)
                        return false;
                    item.Cantidad += ventaDetalle.Cantidad;
                    item.Subtotal += (ventaDetalle.Subtotal / ventaDetalle.Cantidad) * ventaDetalle.Cantidad;
                    break;
                }
            }
            foreach (var item in listaCabecera)
            {
                if (item.Id == ventaDetalle.IdProducto)
                {
                    item.Cantidad += ventaDetalle.Cantidad;
                    item.Subtotal += (ventaDetalle.Subtotal / ventaDetalle.Cantidad) * ventaDetalle.Cantidad;
                    return true;
                }
            }
            return false;
        }

        private bool ComprobarSiEsNuevaVenta(VentaDetalleEntidad ventaDetalle)
        {
            
            if (factura.ListaVentaDetalle.Count == 0)
                return true;
            VentaDetalleEntidad detalle = factura.ListaVentaDetalle.Find(a => a.IdProducto == ventaDetalle.IdProducto);
            if (detalle != null)
                return false;
            else
                return true;
        }

        #region CONTROLES_TEXTBOX
        private void textBox_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void textBox_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void textBox_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        #endregion

        private void dataGridViewDetalle_Venta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Deseas eliminar este producto?","Confirmar eliminacion",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridViewDetalle_Venta.Rows[e.RowIndex].Cells["id"].Value.ToString());
                factura.ListaVentaDetalle.RemoveAll(a => a.IdProducto == id);
                listaCabecera.RemoveAll(a => a.Id == id);
                calcularTotalYSubtotal();
                cargarListaVentaDetalle();
            }
        }

        private void LimpiarCamposCliente()
        {
            textBox_Nombre.Text = string.Empty;
            textBox_Apellido.Text = string.Empty;
            textBox_Cedula.Text = string.Empty;
            textBox_Direccion.Text = string.Empty;
            textBox_Correo.Text = string.Empty;
            textBox_Telefono.Text = string.Empty;
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            if (!GuardarFacturaYCliente())
                return;
            GenerarFactura();
            LimpiarTodosLosCampos();
        }

        private bool GuardarFacturaYCliente()
        {
            if (HayCamposVacios())
                return false;
            if (ComprobarListadoConBD())
                return false;
            GuardarCliente();
            GuardarFactura();
            return true;
        }

        private bool ComprobarListadoConBD()
        {
            string productoInexistente = FacturaNegocio.ComprobarExistenciaProductos(factura);
            if (string.IsNullOrEmpty(productoInexistente))
            {
                MessageBox.Show("Error, no se puede realizar la venta, el producto no existe en la base de datos", "Comprobar Productos", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void GenerarFactura()
        {
            // Configurar las propiedades de la ventana de vista previa
            vistaPrevia.Width = Screen.PrimaryScreen.Bounds.Width; // Ancho de la pantalla
            vistaPrevia.Height = Screen.PrimaryScreen.Bounds.Height; // Alto de la pantalla
            vistaPrevia.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana
            vistaPrevia.WindowState = FormWindowState.Maximized; // Maximizar la ventana

            // Mostrar la ventana de vista previa
            vistaPrevia.ShowDialog();
        }

        private bool HayCamposVacios()
        {
            if (
                textBox_Nombre.Text == string.Empty ||
                textBox_Apellido.Text == string.Empty ||
                textBox_Cedula.Text == string.Empty ||
                textBox_Direccion.Text == string.Empty ||
                textBox_Correo.Text == string.Empty ||
                textBox_Telefono.Text == string.Empty
                )
            {
                MessageBox.Show("Espacios Vacios en el cliente", "Datos del Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            if (
                Convert.ToDecimal(textBox_Total.Text) == 0
                )
            {
                MessageBox.Show("Sin datos en la Tabla", "Detalle de la factura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            return false;
        }
        private void GuardarCliente()
        {
            //Obtengo al cliente si existe
            cliente = ClienteNegocio.BuscarClientePorCedula(textBox_Cedula.Text);

            if (cliente == null)
                cliente = new ClienteEntidad();

            // Guardo los cambios para el cliente
            cliente.Nombre = textBox_Nombre.Text;
            cliente.Apellido = textBox_Apellido.Text;
            cliente.Cedula = textBox_Cedula.Text;
            cliente.Direccion = textBox_Direccion.Text;
            cliente.Correo = textBox_Correo.Text;
            cliente.Telefono = textBox_Telefono.Text;

            cliente = ClienteNegocio.Guardar(cliente);
        }
        private void GuardarFactura()
        {
            factura.IdCliente = cliente.Id;
            factura.Iva = Convert.ToDecimal(textBox_IVA.Text);
            factura.Subtotal = Convert.ToDecimal(textBox_Subtotal.Text);
            factura.Total = Convert.ToDecimal(textBox_Total.Text);
            factura.FechaVenta = dateTimePicker_fecha.Value;

            if (FacturaNegocio.Guardar(factura))
            {
                MessageBox.Show("Factura Realizada", "Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error en los datos de la factura", "Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarTodosLosCampos()
        {
            factura = new FacturaEntidad();
            listaCabecera = new List<VentaDetalleProductoCabeceraEntidad>();
            UltimoNumeroComprobante();
            calcularTotalYSubtotal();
            cargarListaVentaDetalle();
            LimpiarCamposCliente();
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarTodosLosCampos();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_VentasAlCliente ventasAlCliente = new Form_VentasAlCliente())
            {
                ventasAlCliente.ShowDialog();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_Clientes form_Cliente = new Form_Clientes())
            {
                form_Cliente.ShowDialog();
            }
        }

        private void vistaPrevia_Load(object sender, EventArgs e)
        {
            
        }

        private void ImprimirDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fuenteCabezera = new Font("Calibri", 14, FontStyle.Bold);
            Font fuenteCabezera2 = new Font("Calibri", 12);
            Font fuenteCuerpo = new Font("Time New Roman", 10);

            int y = 5;

            e.Graphics.DrawString("FARMACIA GIRASOL", fuenteCabezera, Brushes.DarkGray, 120, y += 20);
            e.Graphics.DrawString("DETALLE DE LA VENTA", fuenteCabezera2, Brushes.DarkBlue, 120, y += 20);
            e.Graphics.DrawString("CLIENTE: " + cliente.Nombre, fuenteCuerpo, Brushes.Black, 20, y += 40);
            e.Graphics.DrawString("CEDULA: " + cliente.Cedula, fuenteCuerpo, Brushes.Black, 20, y += 40);
            e.Graphics.DrawString("TELEFONO: " + cliente.Telefono, fuenteCuerpo, Brushes.Black, 20, y += 40);
            e.Graphics.DrawString("CORREO: " + cliente.Correo, fuenteCuerpo, Brushes.Black, 20, y += 40);
            e.Graphics.DrawString("DIRECCION: " + cliente.Direccion, fuenteCuerpo, Brushes.Black, 20, y += 40);
            e.Graphics.DrawString("FECHA COMPROBANTE: " + factura.FechaVenta, fuenteCuerpo, Brushes.Black, 20, y += 40);

            y += 20;

            e.Graphics.DrawString("PRODUCTO", fuenteCuerpo, Brushes.Black, 20, y += 40);
            e.Graphics.DrawString("PRECIO UNITARIO", fuenteCuerpo, Brushes.Black, 140, y);
            e.Graphics.DrawString("CANTIDAD", fuenteCuerpo, Brushes.Black, 250, y);
            e.Graphics.DrawString("SUBTOTAL", fuenteCuerpo, Brushes.Black, 325, y);

            foreach (var item in listaCabecera)
            {
                e.Graphics.DrawString(item.NombreComercial, fuenteCuerpo, Brushes.Black, 20, y += 40);
                e.Graphics.DrawString(item.Precio.ToString("0." +
                    "" +
                    "00"), fuenteCuerpo, Brushes.Black, 140, y);
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
