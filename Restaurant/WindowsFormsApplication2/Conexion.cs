using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    class Conexion
    {
        public SqlConnection con = new SqlConnection();

      public bool CrearConexion(string dirServer, string nombreDB, string usuario, string clave)
      {
          string CadenaConexionSA;
          string CadenaConexionWin;

          CadenaConexionSA = "data source=" + dirServer +
                          ";" + "initial catalog= " + nombreDB +
                          ";user id=" + usuario + ";password=" + clave;

          CadenaConexionWin = "data source=" + dirServer +
                          ";" + "initial catalog= " + nombreDB +
                          ";Integrated Security = True";

        
          try
          {
              con = new SqlConnection(CadenaConexionWin);
              con.Open();


          }
          catch (Exception e)
          {
              return false;

          }
          return true;
      }

    }
 partial class General {

     public static string Server = @".\SQLEXPRESS";
     public static string DataBase = "ElfmanStrauss";
        public static string User = "";
        public static string Pass = "";


    }

    

    }
