using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    class ConexionLoguin
    {
        public string cadenaconexcion;
        protected string sql;
        protected int resultado;
        protected SqlConnection cnn;
        protected SqlCommand comandosql;
        protected string mensaje;


        public ConexionLoguin()
        {

            this.cadenaconexcion = (@"Data Source=VAMPER-PC\SQLEXPRESS;Initial Catalog=ElfmanStrauss;Integrated Security=True");
            this.cnn = new SqlConnection(this.cadenaconexcion);
        }

        public string Mensaje
        {
        get{
        return this.mensaje;
        
        }
        }

    }
}
