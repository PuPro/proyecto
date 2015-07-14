using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //agregar usuario
        private void bt_guardarUsuario_Click(object sender, EventArgs e)
        {


            if (txt_nombreUsuario.Text == "")
            {

                MessageBox.Show("Debe llenar todos los campos");
                return;
            } if (txt_apellidoUsuario.Text == "")
            {

                MessageBox.Show("Debe llenar todos los campos");
                return;
            } if (txtusuarioUsuario.Text == "")
            {

                MessageBox.Show("Debe llenar todos los campos");
                return;
            } if (txt_contraseñaUsuario.Text == "")
            {

                MessageBox.Show("Debe llenar todos los campos");
                return;
            } if (txt_rutUsuario.Text == "")
            {

                MessageBox.Show("Debe llenar todos los campos");
                return;
            }
            
            
            
            
            


            if (MessageBox.Show("Estas seguro que desas agregar", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Gestion Agregar = new Gestion();


                    if (Agregar.agregar_usuario(txt_nombreUsuario.Text, txt_apellidoUsuario.Text, txtusuarioUsuario.Text, txt_contraseñaUsuario.Text, txt_rutUsuario.Text) > 0)
                    {


                        MessageBox.Show("Usuario Agregado Exitosamente ...");


                    }
                    else
                    {
                        MessageBox.Show("Error Al Agregar usuario ...");
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }


        //envia la informacion del txt a la gestion dgv usuario y cargar datos en la grilla usuario
        private void txt_buscarUsuario_TextChanged(object sender, EventArgs e)
        {

            Gestion lista = new Gestion();

            dgv_usuario.DataSource = lista.cargarDGVusuario(txt_buscarUsuario.Text);

        }


        public string ID_usuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string rut { get; set; }


        //hacer clic en la celda para debolver datos de usuario
        private void dgv_usuario_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            ID_usuario = dgv_usuario.Rows[e.RowIndex].Cells[0].Value.ToString();
            nombre = dgv_usuario.Rows[e.RowIndex].Cells[1].Value.ToString();
            apellido = dgv_usuario.Rows[e.RowIndex].Cells[2].Value.ToString();
            usuario = dgv_usuario.Rows[e.RowIndex].Cells[3].Value.ToString();
            contraseña = dgv_usuario.Rows[e.RowIndex].Cells[4].Value.ToString();
            rut = dgv_usuario.Rows[e.RowIndex].Cells[5].Value.ToString();

            txt_nombreUsuario.Text = nombre;
            txt_apellidoUsuario.Text = apellido;
            txtusuarioUsuario.Text = usuario;
            txt_contraseñaUsuario.Text = contraseña;
            txt_rutUsuario.Text = rut;

        }


        //envia informacion para modificar el usuario
        private void bt_modificarUsuario_Click(object sender, EventArgs e)
        {



            if (txt_nombreUsuario.Text == "")
            {

                MessageBox.Show("Debe llenar todos los campos");
                return;
            } if (txt_apellidoUsuario.Text == "")
            {

                MessageBox.Show("Debe llenar todos los campos");
                return;
            } if (txtusuarioUsuario.Text == "")
            {

                MessageBox.Show("Debe llenar todos los campos");
                return;
            } if (txt_contraseñaUsuario.Text == "")
            {

                MessageBox.Show("Debe llenar todos los campos");
                return;
            } if (txt_rutUsuario.Text == "")
            {

                MessageBox.Show("Debe llenar todos los campos");
                return;
            }
            if (MessageBox.Show("Estas seguro que desas modificar", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    Gestion modificar = new Gestion();


                    if (modificar.modificar_usuario(Convert.ToInt32(ID_usuario), txt_nombreUsuario.Text, txt_apellidoUsuario.Text, txtusuarioUsuario.Text, txt_contraseñaUsuario.Text, txt_rutUsuario.Text) > 0)
                    {


                        MessageBox.Show("Usuario modificado ...");


                    }
                    else
                    {
                        MessageBox.Show("Error Al modificar ...");
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }


        //envia la ide del usuario que quieres eliminar 
        private void bt_eliminarUsuario_Click(object sender, EventArgs e)
        {



            if (txt_nombreUsuario.Text == "")
            {

                MessageBox.Show("Debe llenar todos los campos");
                return;
            } if (txt_apellidoUsuario.Text == "")
            {

                MessageBox.Show("Debe llenar todos los campos");
                return;
            } if (txtusuarioUsuario.Text == "")
            {

                MessageBox.Show("Debe llenar todos los campos");
                return;
            } if (txt_contraseñaUsuario.Text == "")
            {

                MessageBox.Show("Debe llenar todos los campos");
                return;
            } if (txt_rutUsuario.Text == "")
            {

                MessageBox.Show("Debe llenar todos los campos");
                return;
            }



            if (MessageBox.Show("Estas seguro que desas eliminar", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
            
            try
            {
                Gestion modificar = new Gestion();


                if (modificar.eliminar_usuario (Convert.ToInt32(ID_usuario)) > 0)
                {


                    MessageBox.Show("Usuario Eliminado ...");


                    txt_nombreUsuario.Text = null;
                    txt_apellidoUsuario.Text =null;
                    txtusuarioUsuario.Text = null;
                    txt_contraseñaUsuario.Text = null;
                    txt_rutUsuario.Text = null;


                }
                else
                {
                    MessageBox.Show("Error Al Eliminar ...");
                }
            }
            catch (Exception)
            {

                throw;
            }


            }

        }

        private void bt_salirAdmin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("cerrar sesión ...", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Principal prin = new Principal();
                prin.Show();

                MessageBox.Show("sesión cerrada...");

                this.Close();

            }
        }







    }
}
