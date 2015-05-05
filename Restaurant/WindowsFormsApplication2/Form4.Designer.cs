namespace WindowsFormsApplication2
{
    partial class Form4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_usuarioAdministracion = new System.Windows.Forms.TextBox();
            this.txt_contraseñaAdmonistracion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_salir_administracion = new System.Windows.Forms.Button();
            this.bt_ingresar_administracion = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bt_salir_administracion);
            this.groupBox1.Controls.Add(this.bt_ingresar_administracion);
            this.groupBox1.Controls.Add(this.txt_usuarioAdministracion);
            this.groupBox1.Controls.Add(this.txt_contraseñaAdmonistracion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 320);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(118, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 46);
            this.label3.TabIndex = 10;
            this.label3.Text = "ADMINISTRACION";
            // 
            // txt_usuarioAdministracion
            // 
            this.txt_usuarioAdministracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuarioAdministracion.Location = new System.Drawing.Point(206, 141);
            this.txt_usuarioAdministracion.Name = "txt_usuarioAdministracion";
            this.txt_usuarioAdministracion.Size = new System.Drawing.Size(265, 23);
            this.txt_usuarioAdministracion.TabIndex = 3;
            this.txt_usuarioAdministracion.Text = "17284952-0";
            // 
            // txt_contraseñaAdmonistracion
            // 
            this.txt_contraseñaAdmonistracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseñaAdmonistracion.Location = new System.Drawing.Point(206, 179);
            this.txt_contraseñaAdmonistracion.Name = "txt_contraseñaAdmonistracion";
            this.txt_contraseñaAdmonistracion.PasswordChar = '*';
            this.txt_contraseñaAdmonistracion.Size = new System.Drawing.Size(265, 23);
            this.txt_contraseñaAdmonistracion.TabIndex = 4;
            this.txt_contraseñaAdmonistracion.Text = "9520";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONTRASEÑA :";
            // 
            // bt_salir_administracion
            // 
            this.bt_salir_administracion.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.logout;
            this.bt_salir_administracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_salir_administracion.Location = new System.Drawing.Point(323, 224);
            this.bt_salir_administracion.Name = "bt_salir_administracion";
            this.bt_salir_administracion.Size = new System.Drawing.Size(179, 71);
            this.bt_salir_administracion.TabIndex = 9;
            this.bt_salir_administracion.UseVisualStyleBackColor = true;
            // 
            // bt_ingresar_administracion
            // 
            this.bt_ingresar_administracion.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.login;
            this.bt_ingresar_administracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_ingresar_administracion.Location = new System.Drawing.Point(89, 224);
            this.bt_ingresar_administracion.Name = "bt_ingresar_administracion";
            this.bt_ingresar_administracion.Size = new System.Drawing.Size(179, 71);
            this.bt_ingresar_administracion.TabIndex = 8;
            this.bt_ingresar_administracion.UseVisualStyleBackColor = true;
            this.bt_ingresar_administracion.Click += new System.EventHandler(this.bt_ingresar_administracion_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(697, 408);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_salir_administracion;
        private System.Windows.Forms.Button bt_ingresar_administracion;
        private System.Windows.Forms.TextBox txt_usuarioAdministracion;
        private System.Windows.Forms.TextBox txt_contraseñaAdmonistracion;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}