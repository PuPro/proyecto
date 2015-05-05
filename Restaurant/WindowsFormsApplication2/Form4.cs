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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        int cerrar = 0;

        private void bt_ingresar_administracion_Click(object sender, EventArgs e)
        {


            UsuarioAdmin usuarioOB = new UsuarioAdmin();
            usuarioOB.Usuario = this.txt_usuarioAdministracion.Text;
            usuarioOB.Contraseña = this.txt_contraseñaAdmonistracion.Text;

            if (usuarioOB.buscar() == true)
            {


                MessageBox.Show(usuarioOB.Mensaje, "Loguin...");

                cerrar = 1;

            }
            else
            {

                MessageBox.Show(usuarioOB.Mensaje, "ERROR...");


                cerrar = 0;


            }


            if (cerrar == 1)
            {

                this.Close();


            }
            else
            {




            }



        }
    }
}
