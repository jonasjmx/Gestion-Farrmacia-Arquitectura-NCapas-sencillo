namespace Presentacion
{
    partial class Form_VentasDeLaFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_VentasDeLaFactura));
            this.dataGridView_VentasFactura = new System.Windows.Forms.DataGridView();
            this.label_Ventas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label__NumeroFactura = new System.Windows.Forms.Label();
            this.label_CedulaCLiente = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_NombreCliente = new System.Windows.Forms.Label();
            this.label_ApellidoCliente = new System.Windows.Forms.Label();
            this.Imprimir = new System.Windows.Forms.Button();
            this.vistaPrevia = new System.Windows.Forms.PrintPreviewDialog();
            this.ImprimirDoc = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_VentasFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_VentasFactura
            // 
            this.dataGridView_VentasFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_VentasFactura.Location = new System.Drawing.Point(12, 83);
            this.dataGridView_VentasFactura.Name = "dataGridView_VentasFactura";
            this.dataGridView_VentasFactura.Size = new System.Drawing.Size(776, 355);
            this.dataGridView_VentasFactura.TabIndex = 0;
            // 
            // label_Ventas
            // 
            this.label_Ventas.AutoSize = true;
            this.label_Ventas.Location = new System.Drawing.Point(12, 9);
            this.label_Ventas.Name = "label_Ventas";
            this.label_Ventas.Size = new System.Drawing.Size(40, 13);
            this.label_Ventas.TabIndex = 1;
            this.label_Ventas.Text = "Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero de Factura: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cedula del cliente:";
            // 
            // label__NumeroFactura
            // 
            this.label__NumeroFactura.AutoSize = true;
            this.label__NumeroFactura.Location = new System.Drawing.Point(138, 34);
            this.label__NumeroFactura.Name = "label__NumeroFactura";
            this.label__NumeroFactura.Size = new System.Drawing.Size(16, 13);
            this.label__NumeroFactura.TabIndex = 4;
            this.label__NumeroFactura.Text = "...";
            // 
            // label_CedulaCLiente
            // 
            this.label_CedulaCLiente.AutoSize = true;
            this.label_CedulaCLiente.Location = new System.Drawing.Point(138, 57);
            this.label_CedulaCLiente.Name = "label_CedulaCLiente";
            this.label_CedulaCLiente.Size = new System.Drawing.Size(16, 13);
            this.label_CedulaCLiente.TabIndex = 5;
            this.label_CedulaCLiente.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(547, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Apellido: ";
            // 
            // label_NombreCliente
            // 
            this.label_NombreCliente.AutoSize = true;
            this.label_NombreCliente.Location = new System.Drawing.Point(368, 57);
            this.label_NombreCliente.Name = "label_NombreCliente";
            this.label_NombreCliente.Size = new System.Drawing.Size(16, 13);
            this.label_NombreCliente.TabIndex = 7;
            this.label_NombreCliente.Text = "...";
            // 
            // label_ApellidoCliente
            // 
            this.label_ApellidoCliente.AutoSize = true;
            this.label_ApellidoCliente.Location = new System.Drawing.Point(603, 57);
            this.label_ApellidoCliente.Name = "label_ApellidoCliente";
            this.label_ApellidoCliente.Size = new System.Drawing.Size(16, 13);
            this.label_ApellidoCliente.TabIndex = 8;
            this.label_ApellidoCliente.Text = "...";
            // 
            // Imprimir
            // 
            this.Imprimir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imprimir.Location = new System.Drawing.Point(672, 456);
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Size = new System.Drawing.Size(116, 33);
            this.Imprimir.TabIndex = 9;
            this.Imprimir.Text = "Imprimir Factura";
            this.Imprimir.UseVisualStyleBackColor = false;
            this.Imprimir.Click += new System.EventHandler(this.Imprimir_Click);
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
            // 
            // ImprimirDoc
            // 
            this.ImprimirDoc.DocumentName = "ImprimirDoc";
            this.ImprimirDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ImprimirDoc_PrintPage);
            // 
            // Form_VentasDeLaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 501);
            this.Controls.Add(this.Imprimir);
            this.Controls.Add(this.label_ApellidoCliente);
            this.Controls.Add(this.label_NombreCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_CedulaCLiente);
            this.Controls.Add(this.label__NumeroFactura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Ventas);
            this.Controls.Add(this.dataGridView_VentasFactura);
            this.Name = "Form_VentasDeLaFactura";
            this.Text = "Ventas de La Factura";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_VentasFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_VentasFactura;
        private System.Windows.Forms.Label label_Ventas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label__NumeroFactura;
        private System.Windows.Forms.Label label_CedulaCLiente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_NombreCliente;
        private System.Windows.Forms.Label label_ApellidoCliente;
        private System.Windows.Forms.Button Imprimir;
        private System.Windows.Forms.PrintPreviewDialog vistaPrevia;
        private System.Drawing.Printing.PrintDocument ImprimirDoc;
    }
}