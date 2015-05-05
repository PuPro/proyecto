namespace WindowsFormsApplication2
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_eliminarUsuario = new System.Windows.Forms.Button();
            this.bt_modificarUsuario = new System.Windows.Forms.Button();
            this.bt_guardarUsuario = new System.Windows.Forms.Button();
            this.txt_contraseñaUsuario = new System.Windows.Forms.TextBox();
            this.txtusuarioUsuario = new System.Windows.Forms.TextBox();
            this.txt_rutUsuario = new System.Windows.Forms.TextBox();
            this.txt_apellidoUsuario = new System.Windows.Forms.TextBox();
            this.txt_nombreUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_usuario = new System.Windows.Forms.DataGridView();
            this.txt_buscarUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_salirAdmin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRACION";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_eliminarUsuario);
            this.groupBox1.Controls.Add(this.bt_modificarUsuario);
            this.groupBox1.Controls.Add(this.bt_guardarUsuario);
            this.groupBox1.Controls.Add(this.txt_contraseñaUsuario);
            this.groupBox1.Controls.Add(this.txtusuarioUsuario);
            this.groupBox1.Controls.Add(this.txt_rutUsuario);
            this.groupBox1.Controls.Add(this.txt_apellidoUsuario);
            this.groupBox1.Controls.Add(this.txt_nombreUsuario);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(65, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 214);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // bt_eliminarUsuario
            // 
            this.bt_eliminarUsuario.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.remove_male_user_98400;
            this.bt_eliminarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_eliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_eliminarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_eliminarUsuario.Location = new System.Drawing.Point(385, 19);
            this.bt_eliminarUsuario.Name = "bt_eliminarUsuario";
            this.bt_eliminarUsuario.Size = new System.Drawing.Size(96, 74);
            this.bt_eliminarUsuario.TabIndex = 12;
            this.bt_eliminarUsuario.Text = "ELIMINAR";
            this.bt_eliminarUsuario.UseVisualStyleBackColor = true;
            this.bt_eliminarUsuario.Click += new System.EventHandler(this.bt_eliminarUsuario_Click);
            // 
            // bt_modificarUsuario
            // 
            this.bt_modificarUsuario.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.edit_male_user_98373;
            this.bt_modificarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_modificarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_modificarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_modificarUsuario.Location = new System.Drawing.Point(283, 108);
            this.bt_modificarUsuario.Name = "bt_modificarUsuario";
            this.bt_modificarUsuario.Size = new System.Drawing.Size(96, 74);
            this.bt_modificarUsuario.TabIndex = 11;
            this.bt_modificarUsuario.Text = "MODIFICAR";
            this.bt_modificarUsuario.UseVisualStyleBackColor = true;
            this.bt_modificarUsuario.Click += new System.EventHandler(this.bt_modificarUsuario_Click);
            // 
            // bt_guardarUsuario
            // 
            this.bt_guardarUsuario.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.add_male_user_98364;
            this.bt_guardarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_guardarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_guardarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_guardarUsuario.Location = new System.Drawing.Point(283, 19);
            this.bt_guardarUsuario.Name = "bt_guardarUsuario";
            this.bt_guardarUsuario.Size = new System.Drawing.Size(96, 74);
            this.bt_guardarUsuario.TabIndex = 10;
            this.bt_guardarUsuario.Text = "GUARDAR";
            this.bt_guardarUsuario.UseVisualStyleBackColor = true;
            this.bt_guardarUsuario.Click += new System.EventHandler(this.bt_guardarUsuario_Click);
            // 
            // txt_contraseñaUsuario
            // 
            this.txt_contraseñaUsuario.Location = new System.Drawing.Point(153, 162);
            this.txt_contraseñaUsuario.Name = "txt_contraseñaUsuario";
            this.txt_contraseñaUsuario.Size = new System.Drawing.Size(100, 20);
            this.txt_contraseñaUsuario.TabIndex = 9;
            // 
            // txtusuarioUsuario
            // 
            this.txtusuarioUsuario.Location = new System.Drawing.Point(153, 129);
            this.txtusuarioUsuario.Name = "txtusuarioUsuario";
            this.txtusuarioUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtusuarioUsuario.TabIndex = 8;
            // 
            // txt_rutUsuario
            // 
            this.txt_rutUsuario.Location = new System.Drawing.Point(153, 96);
            this.txt_rutUsuario.Name = "txt_rutUsuario";
            this.txt_rutUsuario.Size = new System.Drawing.Size(100, 20);
            this.txt_rutUsuario.TabIndex = 7;
            // 
            // txt_apellidoUsuario
            // 
            this.txt_apellidoUsuario.Location = new System.Drawing.Point(153, 63);
            this.txt_apellidoUsuario.Name = "txt_apellidoUsuario";
            this.txt_apellidoUsuario.Size = new System.Drawing.Size(100, 20);
            this.txt_apellidoUsuario.TabIndex = 6;
            // 
            // txt_nombreUsuario
            // 
            this.txt_nombreUsuario.Location = new System.Drawing.Point(153, 30);
            this.txt_nombreUsuario.Name = "txt_nombreUsuario";
            this.txt_nombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.txt_nombreUsuario.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "RUT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "CONTRASEÑA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "USUARIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "APELLIDO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "NOMBRE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_usuario);
            this.groupBox2.Controls.Add(this.txt_buscarUsuario);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(65, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 202);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // dgv_usuario
            // 
            this.dgv_usuario.AllowUserToAddRows = false;
            this.dgv_usuario.AllowUserToDeleteRows = false;
            this.dgv_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuario.Location = new System.Drawing.Point(35, 61);
            this.dgv_usuario.Name = "dgv_usuario";
            this.dgv_usuario.ReadOnly = true;
            this.dgv_usuario.Size = new System.Drawing.Size(441, 113);
            this.dgv_usuario.TabIndex = 2;
            this.dgv_usuario.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_usuario_CellMouseDoubleClick);
            // 
            // txt_buscarUsuario
            // 
            this.txt_buscarUsuario.Location = new System.Drawing.Point(171, 35);
            this.txt_buscarUsuario.Name = "txt_buscarUsuario";
            this.txt_buscarUsuario.Size = new System.Drawing.Size(305, 20);
            this.txt_buscarUsuario.TabIndex = 1;
            this.txt_buscarUsuario.TextChanged += new System.EventHandler(this.txt_buscarUsuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "NOMBRE USUARIO";
            // 
            // bt_salirAdmin
            // 
            this.bt_salirAdmin.ForeColor = System.Drawing.Color.Black;
            this.bt_salirAdmin.Location = new System.Drawing.Point(573, 12);
            this.bt_salirAdmin.Name = "bt_salirAdmin";
            this.bt_salirAdmin.Size = new System.Drawing.Size(75, 23);
            this.bt_salirAdmin.TabIndex = 27;
            this.bt_salirAdmin.Text = "SALIR";
            this.bt_salirAdmin.UseVisualStyleBackColor = true;
            this.bt_salirAdmin.Click += new System.EventHandler(this.bt_salirAdmin_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(660, 537);
            this.Controls.Add(this.bt_salirAdmin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "ElfmanStrauss";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_modificarUsuario;
        private System.Windows.Forms.Button bt_guardarUsuario;
        private System.Windows.Forms.TextBox txt_contraseñaUsuario;
        private System.Windows.Forms.TextBox txtusuarioUsuario;
        private System.Windows.Forms.TextBox txt_rutUsuario;
        private System.Windows.Forms.TextBox txt_apellidoUsuario;
        private System.Windows.Forms.TextBox txt_nombreUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_usuario;
        private System.Windows.Forms.TextBox txt_buscarUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_eliminarUsuario;
        private System.Windows.Forms.Button bt_salirAdmin;
    }
}