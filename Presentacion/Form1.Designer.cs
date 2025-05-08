namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_Total = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_Subtotal = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_IVA = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_IdProducto = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.button_Agregar = new System.Windows.Forms.Button();
            this.dataGridViewDetalle_Venta = new System.Windows.Forms.DataGridView();
            this.textBox_Cantidad = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_Precio = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_Presentacion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_NombreGenerico = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_NombreComercial = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button_Productos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox_BuscarCliente = new System.Windows.Forms.PictureBox();
            this.dateTimePicker_fecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Direccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Correo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_Comprobante = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Telefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Cedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.vistaPrevia = new System.Windows.Forms.PrintPreviewDialog();
            this.ImprimirDoc = new System.Drawing.Printing.PrintDocument();
            this.MenuImpresion = new System.Windows.Forms.PrintDialog();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalle_Venta)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BuscarCliente)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1646, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaVentaToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevaVentaToolStripMenuItem
            // 
            this.nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            this.nuevaVentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaVentaToolStripMenuItem.Text = "Nueva Venta";
            this.nuevaVentaToolStripMenuItem.Click += new System.EventHandler(this.nuevaVentaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturasToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.salirToolStripMenuItem.Text = "Datos";
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facturasToolStripMenuItem.Text = "Facturas";
            this.facturasToolStripMenuItem.Click += new System.EventHandler(this.facturasToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // textBox_Total
            // 
            this.textBox_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Total.Location = new System.Drawing.Point(79, 68);
            this.textBox_Total.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Total.Name = "textBox_Total";
            this.textBox_Total.ReadOnly = true;
            this.textBox_Total.Size = new System.Drawing.Size(76, 21);
            this.textBox_Total.TabIndex = 18;
            this.textBox_Total.Text = "0,00";
            this.textBox_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 70);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Total($)";
            // 
            // textBox_Subtotal
            // 
            this.textBox_Subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Subtotal.Location = new System.Drawing.Point(79, 43);
            this.textBox_Subtotal.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Subtotal.Name = "textBox_Subtotal";
            this.textBox_Subtotal.ReadOnly = true;
            this.textBox_Subtotal.Size = new System.Drawing.Size(76, 21);
            this.textBox_Subtotal.TabIndex = 16;
            this.textBox_Subtotal.Text = "0,00";
            this.textBox_Subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 46);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "subTotal($)";
            // 
            // textBox_IVA
            // 
            this.textBox_IVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_IVA.Location = new System.Drawing.Point(79, 18);
            this.textBox_IVA.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_IVA.Name = "textBox_IVA";
            this.textBox_IVA.ReadOnly = true;
            this.textBox_IVA.Size = new System.Drawing.Size(76, 21);
            this.textBox_IVA.TabIndex = 14;
            this.textBox_IVA.Text = "0,00";
            this.textBox_IVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 21);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "IVA($)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.textBox_IdProducto);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.button_Agregar);
            this.groupBox2.Controls.Add(this.dataGridViewDetalle_Venta);
            this.groupBox2.Controls.Add(this.textBox_Cantidad);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.textBox_Precio);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBox_Presentacion);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBox_NombreGenerico);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox_NombreComercial);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.button_Productos);
            this.groupBox2.Location = new System.Drawing.Point(8, 245);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1617, 536);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS DE LA VENTA";
            // 
            // textBox_IdProducto
            // 
            this.textBox_IdProducto.Location = new System.Drawing.Point(17, 81);
            this.textBox_IdProducto.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_IdProducto.Name = "textBox_IdProducto";
            this.textBox_IdProducto.ReadOnly = true;
            this.textBox_IdProducto.Size = new System.Drawing.Size(77, 20);
            this.textBox_IdProducto.TabIndex = 14;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 62);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(16, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "Id";
            // 
            // button_Agregar
            // 
            this.button_Agregar.Location = new System.Drawing.Point(1436, 64);
            this.button_Agregar.Margin = new System.Windows.Forms.Padding(2);
            this.button_Agregar.Name = "button_Agregar";
            this.button_Agregar.Size = new System.Drawing.Size(156, 40);
            this.button_Agregar.TabIndex = 12;
            this.button_Agregar.Text = "Agregar";
            this.button_Agregar.UseVisualStyleBackColor = true;
            this.button_Agregar.Click += new System.EventHandler(this.button_Agregar_Click);
            // 
            // dataGridViewDetalle_Venta
            // 
            this.dataGridViewDetalle_Venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalle_Venta.Location = new System.Drawing.Point(15, 124);
            this.dataGridViewDetalle_Venta.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDetalle_Venta.Name = "dataGridViewDetalle_Venta";
            this.dataGridViewDetalle_Venta.RowHeadersWidth = 51;
            this.dataGridViewDetalle_Venta.RowTemplate.Height = 24;
            this.dataGridViewDetalle_Venta.Size = new System.Drawing.Size(1579, 377);
            this.dataGridViewDetalle_Venta.TabIndex = 11;
            this.dataGridViewDetalle_Venta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetalle_Venta_CellClick);
            // 
            // textBox_Cantidad
            // 
            this.textBox_Cantidad.Location = new System.Drawing.Point(1213, 84);
            this.textBox_Cantidad.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Cantidad.MaxLength = 3;
            this.textBox_Cantidad.Name = "textBox_Cantidad";
            this.textBox_Cantidad.Size = new System.Drawing.Size(76, 20);
            this.textBox_Cantidad.TabIndex = 10;
            this.textBox_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Cantidad_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1211, 62);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Cantidad";
            // 
            // textBox_Precio
            // 
            this.textBox_Precio.Location = new System.Drawing.Point(1021, 84);
            this.textBox_Precio.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Precio.Name = "textBox_Precio";
            this.textBox_Precio.ReadOnly = true;
            this.textBox_Precio.Size = new System.Drawing.Size(92, 20);
            this.textBox_Precio.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1016, 62);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Precio";
            // 
            // textBox_Presentacion
            // 
            this.textBox_Presentacion.Location = new System.Drawing.Point(791, 84);
            this.textBox_Presentacion.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Presentacion.Name = "textBox_Presentacion";
            this.textBox_Presentacion.ReadOnly = true;
            this.textBox_Presentacion.Size = new System.Drawing.Size(160, 20);
            this.textBox_Presentacion.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(789, 62);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Presentacion ";
            // 
            // textBox_NombreGenerico
            // 
            this.textBox_NombreGenerico.Location = new System.Drawing.Point(518, 84);
            this.textBox_NombreGenerico.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_NombreGenerico.Name = "textBox_NombreGenerico";
            this.textBox_NombreGenerico.ReadOnly = true;
            this.textBox_NombreGenerico.Size = new System.Drawing.Size(207, 20);
            this.textBox_NombreGenerico.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(516, 62);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Nombre Generico";
            // 
            // textBox_NombreComercial
            // 
            this.textBox_NombreComercial.Location = new System.Drawing.Point(192, 84);
            this.textBox_NombreComercial.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_NombreComercial.Name = "textBox_NombreComercial";
            this.textBox_NombreComercial.ReadOnly = true;
            this.textBox_NombreComercial.Size = new System.Drawing.Size(240, 20);
            this.textBox_NombreComercial.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(187, 62);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Nombre Comercial";
            // 
            // button_Productos
            // 
            this.button_Productos.Location = new System.Drawing.Point(1436, 17);
            this.button_Productos.Margin = new System.Windows.Forms.Padding(2);
            this.button_Productos.Name = "button_Productos";
            this.button_Productos.Size = new System.Drawing.Size(156, 43);
            this.button_Productos.TabIndex = 0;
            this.button_Productos.Text = "Productos";
            this.button_Productos.UseVisualStyleBackColor = true;
            this.button_Productos.Click += new System.EventHandler(this.button_Productos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox_BuscarCliente);
            this.groupBox1.Controls.Add(this.dateTimePicker_fecha);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_Direccion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox_Correo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox_Comprobante);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_Telefono);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_Apellido);
            this.groupBox1.Controls.Add(this.textBox_Nombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_Cedula);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1617, 193);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL CLIENTE";
            // 
            // pictureBox_BuscarCliente
            // 
            this.pictureBox_BuscarCliente.Image = global::Presentacion.Properties.Resources.Buscar;
            this.pictureBox_BuscarCliente.Location = new System.Drawing.Point(1484, 55);
            this.pictureBox_BuscarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_BuscarCliente.Name = "pictureBox_BuscarCliente";
            this.pictureBox_BuscarCliente.Size = new System.Drawing.Size(98, 102);
            this.pictureBox_BuscarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_BuscarCliente.TabIndex = 19;
            this.pictureBox_BuscarCliente.TabStop = false;
            this.pictureBox_BuscarCliente.Click += new System.EventHandler(this.pictureBox_BuscarCliente_Click);
            // 
            // dateTimePicker_fecha
            // 
            this.dateTimePicker_fecha.Location = new System.Drawing.Point(131, 124);
            this.dateTimePicker_fecha.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_fecha.MinDate = new System.DateTime(2024, 6, 4, 0, 0, 0, 0);
            this.dateTimePicker_fecha.Name = "dateTimePicker_fecha";
            this.dateTimePicker_fecha.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker_fecha.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1183, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Correo";
            // 
            // textBox_Direccion
            // 
            this.textBox_Direccion.Location = new System.Drawing.Point(1244, 127);
            this.textBox_Direccion.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Direccion.MaxLength = 30;
            this.textBox_Direccion.Name = "textBox_Direccion";
            this.textBox_Direccion.Size = new System.Drawing.Size(144, 20);
            this.textBox_Direccion.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 72);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "N° Comprobante";
            // 
            // textBox_Correo
            // 
            this.textBox_Correo.Location = new System.Drawing.Point(1244, 64);
            this.textBox_Correo.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Correo.MaxLength = 30;
            this.textBox_Correo.Name = "textBox_Correo";
            this.textBox_Correo.Size = new System.Drawing.Size(144, 20);
            this.textBox_Correo.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 127);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Fecha Venta";
            // 
            // textBox_Comprobante
            // 
            this.textBox_Comprobante.Location = new System.Drawing.Point(134, 66);
            this.textBox_Comprobante.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Comprobante.MaxLength = 10;
            this.textBox_Comprobante.Name = "textBox_Comprobante";
            this.textBox_Comprobante.ReadOnly = true;
            this.textBox_Comprobante.Size = new System.Drawing.Size(194, 20);
            this.textBox_Comprobante.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(906, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1182, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Dirección";
            // 
            // textBox_Telefono
            // 
            this.textBox_Telefono.Location = new System.Drawing.Point(910, 127);
            this.textBox_Telefono.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Telefono.MaxLength = 10;
            this.textBox_Telefono.Name = "textBox_Telefono";
            this.textBox_Telefono.Size = new System.Drawing.Size(144, 20);
            this.textBox_Telefono.TabIndex = 8;
            this.textBox_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Telefono_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(859, 130);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(859, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre";
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Location = new System.Drawing.Point(538, 123);
            this.textBox_Apellido.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Apellido.MaxLength = 30;
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.Size = new System.Drawing.Size(146, 20);
            this.textBox_Apellido.TabIndex = 5;
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(909, 65);
            this.textBox_Nombre.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Nombre.MaxLength = 30;
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(144, 20);
            this.textBox_Nombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // textBox_Cedula
            // 
            this.textBox_Cedula.Location = new System.Drawing.Point(538, 66);
            this.textBox_Cedula.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Cedula.MaxLength = 10;
            this.textBox_Cedula.Name = "textBox_Cedula";
            this.textBox_Cedula.Size = new System.Drawing.Size(145, 20);
            this.textBox_Cedula.TabIndex = 1;
            this.textBox_Cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Cedula_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cédula / RUC: ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 513);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(212, 13);
            this.label20.TabIndex = 20;
            this.label20.Text = "Selecciona el producto que quieres eliminar";
            // 
            // vistaPrevia
            // 
            this.vistaPrevia.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.vistaPrevia.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.vistaPrevia.ClientSize = new System.Drawing.Size(400, 300);
            this.vistaPrevia.Document = this.ImprimirDoc;
            this.vistaPrevia.Enabled = true;
            this.vistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("vistaPrevia.Icon")));
            this.vistaPrevia.Name = "vistaPrevia";
            this.vistaPrevia.Visible = false;
            this.vistaPrevia.Load += new System.EventHandler(this.vistaPrevia_Load);
            // 
            // ImprimirDoc
            // 
            this.ImprimirDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ImprimirDoc_PrintPage);
            // 
            // MenuImpresion
            // 
            this.MenuImpresion.Document = this.ImprimirDoc;
            this.MenuImpresion.UseEXDialog = true;
            // 
            // button_Guardar
            // 
            this.button_Guardar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Guardar.Location = new System.Drawing.Point(24, 112);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(132, 32);
            this.button_Guardar.TabIndex = 21;
            this.button_Guardar.Text = "Guardar Factura";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.button_Guardar);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.textBox_IVA);
            this.groupBox3.Controls.Add(this.textBox_Total);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.textBox_Subtotal);
            this.groupBox3.Location = new System.Drawing.Point(1444, 786);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(181, 159);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1646, 981);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmacia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalle_Venta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BuscarCliente)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_Total;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_Subtotal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_IVA;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Agregar;
        private System.Windows.Forms.DataGridView dataGridViewDetalle_Venta;
        private System.Windows.Forms.TextBox textBox_Cantidad;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_Precio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_Presentacion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_NombreGenerico;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_NombreComercial;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_Productos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox_BuscarCliente;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Comprobante;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Direccion;
        private System.Windows.Forms.TextBox textBox_Correo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Telefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Apellido;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Cedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem nuevaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.TextBox textBox_IdProducto;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog vistaPrevia;
        private System.Windows.Forms.PrintDialog MenuImpresion;
        private System.Drawing.Printing.PrintDocument ImprimirDoc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

