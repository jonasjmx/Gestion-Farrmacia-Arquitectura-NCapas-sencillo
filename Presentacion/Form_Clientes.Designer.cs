namespace Presentacion
{
    partial class Form_Clientes
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
            this.dataGridView_clientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_clientes
            // 
            this.dataGridView_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_clientes.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_clientes.Name = "dataGridView_clientes";
            this.dataGridView_clientes.Size = new System.Drawing.Size(776, 426);
            this.dataGridView_clientes.TabIndex = 0;
            this.dataGridView_clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_clientes_CellClick);
            // 
            // Form_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_clientes);
            this.Name = "Form_Clientes";
            this.Text = "Lista Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_clientes;
    }
}