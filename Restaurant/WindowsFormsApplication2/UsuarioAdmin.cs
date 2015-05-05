using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    class UsuarioAdmin:ConexionLoguin
    {

        private string usuario;
        private string contraseña;


        public UsuarioAdmin()
        {
            usuario = string.Empty;
            contraseña = string.Empty;
            this.sql = string.Empty;

        }

        public string Usuario
        {
            get { return this.usuario;  }
            set { this.usuario = value; }

        }


        public string Contraseña
        {
            get { return this.contraseña; }
            set { this.contraseña = value; }

        }


        public bool buscar()
        {

            //enviar comando sql a bdt
           bool resultado = true;
           this.sql = string.Format(@"SELECT ID_administracion From administracion WHERE usuario='{0}' AND contraseña='{1}'", this.usuario, this.contraseña);
           this.comandosql = new SqlCommand(this.sql, this.cnn);
           this.cnn.Open();
           SqlDataReader reg = null;
           reg = this.comandosql.ExecuteReader();
           if (reg.Read())
           {

               resultado = true;
               this.mensaje = "Bienvenido... Datos Corectos...";

               Form3 fr = new Form3();
               fr.Show();

               
  

           }
           else
           {

               this.mensaje = "Datos Erroneos...  Verificar porfavor....";

               Principal prin = new Principal();
               prin.Show();


           
           }

           this.cnn.Close();
           return resultado;
        }

    }
}
