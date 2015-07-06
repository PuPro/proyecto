namespace WindowsFormsApplication2
{
    partial class InicioReporte
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_listaStock = new System.Windows.Forms.TextBox();
            this.bt_guardar_reporte = new System.Windows.Forms.Button();
            this.txt_user_reporte = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de stock....";
            // 
            // txt_listaStock
            // 
            this.txt_listaStock.Enabled = false;
            this.txt_listaStock.Location = new System.Drawing.Point(91, 75);
            this.txt_listaStock.Multiline = true;
            this.txt_listaStock.Name = "txt_listaStock";
            this.txt_listaStock.Size = new System.Drawing.Size(219, 109);
            this.txt_listaStock.TabIndex = 1;
            // 
            // bt_guardar_reporte
            // 
            this.bt_guardar_reporte.ForeColor = System.Drawing.Color.White;
            this.bt_guardar_reporte.Location = new System.Drawing.Point(177, 204);
            this.bt_guardar_reporte.Name = "bt_guardar_reporte";
            this.bt_guardar_reporte.Size = new System.Drawing.Size(133, 35);
            this.bt_guardar_reporte.TabIndex = 2;
            this.bt_guardar_reporte.Text = "Guardar";
            this.bt_guardar_reporte.UseVisualStyleBackColor = true;
            this.bt_guardar_reporte.Click += new System.EventHandler(this.bt_guardar_reporte_Click);
            // 
            // txt_user_reporte
            // 
            this.txt_user_reporte.Enabled = false;
            this.txt_user_reporte.Location = new System.Drawing.Point(12, 249);
            this.txt_user_reporte.Name = "txt_user_reporte";
            this.txt_user_reporte.Size = new System.Drawing.Size(100, 20);
            this.txt_user_reporte.TabIndex = 3;
            this.txt_user_reporte.Visible = false;
            // 
            // InicioReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(420, 281);
            this.Controls.Add(this.txt_user_reporte);
            this.Controls.Add(this.bt_guardar_reporte);
            this.Controls.Add(this.txt_listaStock);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "InicioReporte";
            this.Text = "Alerta Stock Bajo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_listaStock;
        private System.Windows.Forms.Button bt_guardar_reporte;
        public System.Windows.Forms.TextBox txt_user_reporte;
    }
}