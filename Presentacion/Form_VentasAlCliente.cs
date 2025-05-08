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
    public partial class Form_VentasAlCliente : Form
    {
        ClienteEntidad cliente = new ClienteEntidad();
        public Form_VentasAlCliente()
        {
            InitializeComponent();
        }

        public Form_VentasAlCliente(ClienteEntidad cliente)
        {
            InitializeComponent();

            CargarDatosDelCLiente(cliente);
        }

        private void CargarDatosDelCLiente(ClienteEntidad cliente)
        {
            this.cliente = ClienteNegocio.DevolverFacturasCliente(cliente);
            label_NombreCliente.Text = this.cliente.Nombre;
            label_CedulaCliente.Text = this.cliente.Cedula;
            labelApellidoCliente.Text = this.cliente.Apellido;
            dataGridView_facturasCLiente.DataSource = this.cliente.ListaFacturas;
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            BucarFacturasCliente();
        }

        private void BucarFacturasCliente()
        {
            cliente.Cedula = textBox_CedulaCliente.Text;
            cliente = ClienteNegocio.DevolverFacturasCliente(cliente);

            if (cliente == null || cliente.ListaFacturas == null)
            {
                MessageBox.Show("Sin datos","Buscar Cliente",MessageBoxButtons.OK,MessageBoxIcon.Error);
                EncerarCamposYObjetos();
                return;
            }
            label_NombreCliente.Text = cliente.Nombre;
            label_CedulaCliente.Text = cliente.Cedula;
            labelApellidoCliente.Text = cliente.Apellido;
            dataGridView_facturasCLiente.DataSource = cliente.ListaFacturas;
        }

        private void EncerarCamposYObjetos()
        {
            cliente = new ClienteEntidad();
            cliente.ListaFacturas = new List<FacturaEntidad>();
            textBox_CedulaCliente.Text = string.Empty;
            label_NombreCliente.Text = string.Empty;
            labelApellidoCliente.Text = string.Empty;
            label_CedulaCliente.Text = string.Empty;
            dataGridView_facturasCLiente.DataSource = cliente.ListaFacturas;
        }

        private void textBox_CedulaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void dataGridView_facturasCLiente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idFactura = Convert.ToInt32(dataGridView_facturasCLiente.Rows[e.RowIndex].Cells["id"].Value);
            
            FacturaEntidad factura = cliente.ListaFacturas.FirstOrDefault(x => x.Id == idFactura);
            CargarDatosDeLaFactura(factura);
        }

        private void CargarDatosDeLaFactura(FacturaEntidad factura)
        {
            using (Form_VentasDeLaFactura formVentas = new Form_VentasDeLaFactura(factura))
            {
                formVentas.ShowDialog();
            }
        }

        private void Form_VentasAlCliente_Load(object sender, EventArgs e)
        {
            dataGridView_facturasCLiente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
