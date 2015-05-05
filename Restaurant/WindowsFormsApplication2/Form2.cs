using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        int cerrar = 0;
        
        private void bt_ingresar_login_Click(object sender, EventArgs e)
        {
            Usuarios usuarioOB = new Usuarios();
            usuarioOB.Usuario = this.txt_usuario.Text;
            usuarioOB.Contraseña = this.txt_contraseña.Text;

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

            
            if (cerrar == 1){

                this.Close();


            }
            else
            {
                

                

            }


            

        }

        private void bt_salir_login_Click(object sender, EventArgs e)
        {
  

            this.Close();
            Principal prin = new Principal();
            prin.Show();

        }


       










    }
}
