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
            this.bt_guardar_reporte = new System.Windows.Forms.Button();
            this.txt_user_reporte = new System.Windows.Forms.TextBox();
            this.lbox_reporteStock = new System.Windows.Forms.ListBox();
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
            // bt_guardar_reporte
            // 
            this.bt_guardar_reporte.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bt_guardar_reporte.ForeColor = System.Drawing.Color.Black;
            this.bt_guardar_reporte.Location = new System.Drawing.Point(188, 201);
            this.bt_guardar_reporte.Name = "bt_guardar_reporte";
            this.bt_guardar_reporte.Size = new System.Drawing.Size(133, 35);
            this.bt_guardar_reporte.TabIndex = 2;
            this.bt_guardar_reporte.Text = "Guardar";
            this.bt_guardar_reporte.UseVisualStyleBackColor = false;
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
            // lbox_reporteStock
            // 
            this.lbox_reporteStock.Enabled = false;
            this.lbox_reporteStock.FormattingEnabled = true;
            this.lbox_reporteStock.Location = new System.Drawing.Point(76, 60);
            this.lbox_reporteStock.Name = "lbox_reporteStock";
            this.lbox_reporteStock.Size = new System.Drawing.Size(245, 121);
            this.lbox_reporteStock.TabIndex = 4;
            // 
            // InicioReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(420, 281);
            this.Controls.Add(this.lbox_reporteStock);
            this.Controls.Add(this.txt_user_reporte);
            this.Controls.Add(this.bt_guardar_reporte);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "InicioReporte";
            this.Text = "Alerta Stock Bajo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_guardar_reporte;
        public System.Windows.Forms.TextBox txt_user_reporte;
        private System.Windows.Forms.ListBox lbox_reporteStock;
    }
}