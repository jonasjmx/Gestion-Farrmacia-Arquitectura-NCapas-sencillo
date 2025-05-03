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
    public partial class Formulario_Productos : Form
    {
        public ProductoEntidad producto { get; set; }
        public Formulario_Productos()
        {
            InitializeComponent();
            cargarDatosProductos();
        }

        private void cargarDatosProductos()
        {
            dataGridView_Productos.DataSource = ProductoNegocio.CargarDatosProductos();
        }

        private void dataGridView_Productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView_Productos.Rows[e.RowIndex].Cells["id"].Value.ToString());
            producto = ProductoNegocio.CargarDatosProductoPorId(id);
            this.Close();
        }
    }
}
