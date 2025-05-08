namespace Presentacion
{
    partial class Form_VentasAlCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_VentasAlCliente));
            this.dataGridView_facturasCLiente = new System.Windows.Forms.DataGridView();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.textBox_CedulaCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_NombreCliente = new System.Windows.Forms.Label();
            this.label_CedulaCliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelApellidoCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_facturasCLiente)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_facturasCLiente
            // 
            this.dataGridView_facturasCLiente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_facturasCLiente.Location = new System.Drawing.Point(12, 142);
            this.dataGridView_facturasCLiente.Name = "dataGridView_facturasCLiente";
            this.dataGridView_facturasCLiente.Size = new System.Drawing.Size(776, 296);
            this.dataGridView_facturasCLiente.TabIndex = 0;
            this.dataGridView_facturasCLiente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_facturasCLiente_CellClick);
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(234, 33);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(124, 23);
            this.button_Buscar.TabIndex = 1;
            this.button_Buscar.Text = "Buscar Cliente";
            this.button_Buscar.UseVisualStyleBackColor = true;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // textBox_CedulaCliente
            // 
            this.textBox_CedulaCliente.Location = new System.Drawing.Point(12, 35);
            this.textBox_CedulaCliente.MaxLength = 10;
            this.textBox_CedulaCliente.Name = "textBox_CedulaCliente";
            this.textBox_CedulaCliente.Size = new System.Drawing.Size(192, 20);
            this.textBox_CedulaCliente.TabIndex = 2;
            this.textBox_CedulaCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_CedulaCliente_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cedula del cliente: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:  ";
            // 
            // label_NombreCliente
            // 
            this.label_NombreCliente.AutoSize = true;
            this.label_NombreCliente.Location = new System.Drawing.Point(151, 92);
            this.label_NombreCliente.Name = "label_NombreCliente";
            this.label_NombreCliente.Size = new System.Drawing.Size(16, 13);
            this.label_NombreCliente.TabIndex = 5;
            this.label_NombreCliente.Text = "...";
            // 
            // label_CedulaCliente
            // 
            this.label_CedulaCliente.AutoSize = true;
            this.label_CedulaCliente.Location = new System.Drawing.Point(12, 92);
            this.label_CedulaCliente.Name = "label_CedulaCliente";
            this.label_CedulaCliente.Size = new System.Drawing.Size(16, 13);
            this.label_CedulaCliente.TabIndex = 6;
            this.label_CedulaCliente.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cedula: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Apellido: ";
            // 
            // labelApellidoCliente
            // 
            this.labelApellidoCliente.AutoSize = true;
            this.labelApellidoCliente.Location = new System.Drawing.Point(312, 92);
            this.labelApellidoCliente.Name = "labelApellidoCliente";
            this.labelApellidoCliente.Size = new System.Drawing.Size(16, 13);
            this.labelApellidoCliente.TabIndex = 8;
            this.labelApellidoCliente.Text = "...";
            // 
            // Form_VentasAlCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelApellidoCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_CedulaCliente);
            this.Controls.Add(this.label_NombreCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_CedulaCliente);
            this.Controls.Add(this.button_Buscar);
            this.Controls.Add(this.dataGridView_facturasCLiente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_VentasAlCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Facturas del Cliente";
            this.Load += new System.EventHandler(this.Form_VentasAlCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_facturasCLiente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_facturasCLiente;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.TextBox textBox_CedulaCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_NombreCliente;
        private System.Windows.Forms.Label label_CedulaCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelApellidoCliente;
    }
}