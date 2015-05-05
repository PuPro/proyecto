using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication2
{
    class Gestion
    {

        Conexion connBD = new Conexion();

       


        //agregar clientes a la base de datos

        public int agregar_Clientes(string nombre, string apellido, string rut, string ciudad, string direccion, string fhecha, string n_casa)
        {
            try
            {
                connBD.CrearConexion(General.Server, General.DataBase, General.User, General.Pass);
                SqlCommand cmd = new SqlCommand("agregar_Cliente", connBD.con);
                cmd.CommandType = CommandType.StoredProcedure;

                // agregar parametros que recibe como string
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@rut", rut);
                cmd.Parameters.AddWithValue("@ciudad", ciudad);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@fhecha", fhecha);
                cmd.Parameters.AddWithValue("@n_casa", n_casa);


                cmd.ExecuteNonQuery();
                connBD.con.Close();
                return 1;
            }
            catch (Exception)
            {

                return -1;
            }
        }


        //buscar clientes en bdt y cargar en dgvclientes 

        public DataTable cargarDGVcliente(string nombre)
        {

            connBD.CrearConexion(General.Server, General.DataBase, General.User, General.Pass);
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("buscar_Cliente", connBD.con);
            SqlParameter ParNombre = new SqlParameter();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            ParNombre.ParameterName = "@Nombre";
            ParNombre.Value = nombre;

            da.SelectCommand.Parameters.Add(ParNombre);
            da.Fill(dt);

            return dt;
        }
  
        //modificar clientes
            
        public int modificar_clientes(int ID_cliente, string nombre, string apellido, string rut, string ciudad, string direccion, string fhecha, string n_casa)
        {
            try
            {
                connBD.CrearConexion(General.Server, General.DataBase, General.User, General.Pass);
                SqlCommand cmd = new SqlCommand("modificar_clientes", connBD.con);
                cmd.CommandType = CommandType.StoredProcedure;

                // agregar parametros que recibe como string
                cmd.Parameters.AddWithValue("@ID_cliente", ID_cliente);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@rut", rut);
                cmd.Parameters.AddWithValue("@ciudad", ciudad);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@fhecha", fhecha);
                cmd.Parameters.AddWithValue("@n_casa", n_casa);


                cmd.ExecuteNonQuery();
                connBD.con.Close();
                return 1;
            }
            catch (Exception)
            {

                return -1;
            }
        }

        //-----------------------------------------------------------------------------------------------------
       
        
        //agregar proveedores a la base de datos

        public int agregar_proveedor(string nombre, string contacto, string cargo, string direccion, string numero, string ciudad, string provincia, string pais, string telefono, string celular, string sitio_web)
        {
            try
            {
                connBD.CrearConexion(General.Server, General.DataBase, General.User, General.Pass);
                SqlCommand cmd = new SqlCommand("agregar_proveedor", connBD.con);
                cmd.CommandType = CommandType.StoredProcedure;

                // agregar parametros que recibe como string

                cmd.Parameters.AddWithValue("@nombre",nombre);
                cmd.Parameters.AddWithValue("@contacto",contacto);
                cmd.Parameters.AddWithValue("@cargo",cargo);
                cmd.Parameters.AddWithValue("@direccion",direccion);
                cmd.Parameters.AddWithValue("@numero", numero);
                cmd.Parameters.AddWithValue("@ciudad",ciudad);
                cmd.Parameters.AddWithValue("@provincia",provincia);
                cmd.Parameters.AddWithValue("@pais",pais);
                cmd.Parameters.AddWithValue("@telefono",telefono);
                cmd.Parameters.AddWithValue("@celular",celular);
                cmd.Parameters.AddWithValue("@sitio_web",sitio_web);

                cmd.ExecuteNonQuery();
                connBD.con.Close();
                return 1;
            }
            catch (Exception)
            {

                return -1;
            }
        }


        //buscar proveedores en bdt y cargar en dgvproveedor
        public DataTable cargarDGVproveedor(string nombre)
        {

            connBD.CrearConexion(General.Server, General.DataBase, General.User, General.Pass);
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("buscar_proveedor", connBD.con);
            SqlParameter ParNombre = new SqlParameter();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            ParNombre.ParameterName = "@Nombre";
            ParNombre.Value = nombre;

            da.SelectCommand.Parameters.Add(ParNombre);
            da.Fill(dt);

            return dt;
        }



        //modificar proveedores
        public int modificar_proveedor(int ID_proveedor, string nombre, string contacto, string cargo, string direccion, string numero, string ciudad, string provincia, string pais, string telefono, string celular, string sitio_web)
        {
            try
            {
                connBD.CrearConexion(General.Server, General.DataBase, General.User, General.Pass);
                SqlCommand cmd = new SqlCommand("modificar_proveedores", connBD.con);
                cmd.CommandType = CommandType.StoredProcedure;

                // agregar parametros que recibe como string
                cmd.Parameters.AddWithValue("@ID_proveedor", ID_proveedor);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@contacto", contacto);
                cmd.Parameters.AddWithValue("@cargo", cargo);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@numero", numero);
                cmd.Parameters.AddWithValue("@ciudad", ciudad);
                cmd.Parameters.AddWithValue("@provincia", provincia);
                cmd.Parameters.AddWithValue("@pais", pais);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@celular", celular);
                cmd.Parameters.AddWithValue("@sitio_web", sitio_web);

                cmd.ExecuteNonQuery();
                connBD.con.Close();
                return 1;
            }
            catch (Exception)
            {

                return -1;
            }
        }


        //-----------------------------------------------------------------------------------------------------

        //agregar producto a la base de datos
        public int agregar_productos(string nombre, string stock, string ID_proveedor, int precio, string ID_factura, string descripcion)
        {
            try
            {
                connBD.CrearConexion(General.Server, General.DataBase, General.User, General.Pass);
                SqlCommand cmd = new SqlCommand("agregar_producto", connBD.con);
                cmd.CommandType = CommandType.StoredProcedure;

                // agregar parametros que recibe como string



                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@ID_proveedor", ID_proveedor);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.Parameters.AddWithValue("@ID_factura", ID_factura);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);


                cmd.ExecuteNonQuery();
                connBD.con.Close();
                return 1;
            }
            catch (Exception)
            {

                return -1;
            }
        }


        //buscar proveedores en bdt y cargar en dgvproductos
        public DataTable cargarDGVproductos(string nombre)
        {

            connBD.CrearConexion(General.Server, General.DataBase, General.User, General.Pass);
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("buscar_producto", connBD.con);
            SqlParameter ParNombre = new SqlParameter();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            ParNombre.ParameterName = "@Nombre";
            ParNombre.Value = nombre;

            da.SelectCommand.Parameters.Add(ParNombre);
            da.Fill(dt);

            return dt;
        }

        //modificar productos
        public int modificar_producto(int ID_producto, string stock, int precio)
        {
            try
            {
                connBD.CrearConexion(General.Server, General.DataBase, General.User, General.Pass);
                SqlCommand cmd = new SqlCommand("modificar_producto", connBD.con);
                cmd.CommandType = CommandType.StoredProcedure;

                // agregar parametros que recibe como string
                cmd.Parameters.AddWithValue("@ID_producto", ID_producto);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@precio", precio);

                cmd.ExecuteNonQuery();
                connBD.con.Close();
                return 1;
            }
            catch (Exception)
            {

                return -1;
            }
        }


        //-----------------------------------------------------------------------------------------------------

        //agregar producto a la base de datos
        public int agregar_usuario(string nombre,string apellido,string usuario,string contraseña,string rut)
        {
            try
            {
                connBD.CrearConexion(General.Server, General.DataBase, General.User, General.Pass);
                SqlCommand cmd = new SqlCommand("agregar_usuario", connBD.con);
                cmd.CommandType = CommandType.StoredProcedure;

                // agregar parametros que recibe como string



                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);
                cmd.Parameters.AddWithValue("@rut", rut);
               


                cmd.ExecuteNonQuery();
                connBD.con.Close();
                return 1;
            }
            catch (Exception)
            {

                return -1;
            }
        }


        //buscar proveedores en bdt y cargar en dgvusuario
        public DataTable cargarDGVusuario(string nombre)
        {

            connBD.CrearConexion(General.Server, General.DataBase, General.User, General.Pass);
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("buscar_usuario", connBD.con);
            SqlParameter ParNombre = new SqlParameter();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            ParNombre.ParameterName = "@Nombre";
            ParNombre.Value = nombre;

            da.SelectCommand.Parameters.Add(ParNombre);
            da.Fill(dt);

            return dt;
        }

        //modificar usuario
        public int modificar_usuario(int ID_usuario, string nombre, string apellido, string usuario, string contraseña, string rut)
        {
            try
            {
                connBD.CrearConexion(General.Server, General.DataBase, General.User, General.Pass);
                SqlCommand cmd = new SqlCommand("modificar_usuario", connBD.con);
                cmd.CommandType = CommandType.StoredProcedure;

                // agregar parametros que recibe como string
                cmd.Parameters.AddWithValue("@ID_usuario", ID_usuario);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);
                cmd.Parameters.AddWithValue("@rut", rut);

                cmd.ExecuteNonQuery();
                connBD.con.Close();
                return 1;
            }
            catch (Exception)
            {

                return -1;
            }
        }

        //eliminar usuario
        public int eliminar_usuario(int ID_usuario)
        {
            try
            {
                connBD.CrearConexion(General.Server, General.DataBase, General.User, General.Pass);
                SqlCommand cmd = new SqlCommand("eliminar_usuario", connBD.con);
                cmd.CommandType = CommandType.StoredProcedure;

                // agregar parametros que recibe como string
                cmd.Parameters.AddWithValue("@ID_usuario", ID_usuario);

                cmd.ExecuteNonQuery();
                connBD.con.Close();
                return 1;
            }
            catch (Exception)
            {

                return -1;
            }
        }

        //-----------------------------------------------------------------------------------------------------


        //agregar venta a la base de datos
        public int agregar_venta(string hora,string fecha,int ID_usuario,int ID_cliente,int total_venta)
        {


            try
            {
                connBD.CrearConexion(General.Server, General.DataBase, General.User, General.Pass);
                SqlCommand cmd = new SqlCommand("agregar_venta", connBD.con);
                cmd.CommandType = CommandType.StoredProcedure;

                // agregar parametros que recibe como string



                cmd.Parameters.AddWithValue("@hora", hora);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@ID_usuario", ID_usuario);
                cmd.Parameters.AddWithValue("@ID_cliente", ID_cliente);
                cmd.Parameters.AddWithValue("@total_venta", total_venta);



                cmd.ExecuteNonQuery();
                connBD.con.Close();
                return 1;
            }
            catch (Exception)
            {

                return -1;
            }
        }


    }
}
