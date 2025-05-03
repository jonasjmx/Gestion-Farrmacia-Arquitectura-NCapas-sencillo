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
    public partial class Form_Clientes : Form
    {
        public Form_Clientes()
        {
            InitializeComponent();
            cargarDatosClientes();
        }

        private void cargarDatosClientes()
        {
            dataGridView_clientes.DataSource = ClienteNegocio.ListaClientes();
        }

        private void dataGridView_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView_clientes.Rows[e.RowIndex].Cells["id"].Value.ToString());
            ClienteEntidad cliente = ClienteNegocio.BuscarClientePorId(id);

            using (Form_VentasAlCliente form = new Form_VentasAlCliente(cliente))
            {
                form.ShowDialog();
            }
        }
    }
}
