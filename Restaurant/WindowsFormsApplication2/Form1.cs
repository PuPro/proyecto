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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmb_provedorProductos();
            cmb_vendedorVentas();


        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }




        //-------------------------------------------------------------------------------------

        // agregar cliente 
        private void bt_guardarCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desas agregar", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Gestion Agregar = new Gestion();


                    if (Agregar.agregar_Clientes(txt_nombreCliente.Text, txt_apellidoCliente.Text, txt_rutCliente.Text, txt_ciudadCliente.Text, txt_direccionCliente.Text, dTime_Cliente.Text, txt_numeroCasaCliente.Text) > 0)
                    {


                        MessageBox.Show("Cliente Agregado Exitosamente ...");


                    }
                    else
                    {
                        MessageBox.Show("Error Al Agregar Cliente ...");
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }


        //envia la informacion del txt a la gestion dgv cliente y cargar datos en la grilla cliente
        private void txt_buscarCliente_TextChanged(object sender, EventArgs e)
        {

            Gestion lista = new Gestion();

            dgv_Clinete.DataSource = lista.cargarDGVcliente(txt_buscarCliente.Text);

        }


        //agregar y devolver valores cliente
        public string ID_cliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string rut { get; set; }
        public string ciudad { get; set; }
        public string direccion { get; set; }
        public string fhecha { get; set; }
        public string n_casa { get; set; }

        //acer clic en la celda para devolver el valor cliente

        private void dgv_Clinete_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID_cliente = dgv_Clinete.Rows[e.RowIndex].Cells[0].Value.ToString();
            nombre = dgv_Clinete.Rows[e.RowIndex].Cells[1].Value.ToString();
            apellido = dgv_Clinete.Rows[e.RowIndex].Cells[2].Value.ToString();
            rut = dgv_Clinete.Rows[e.RowIndex].Cells[3].Value.ToString();
            ciudad = dgv_Clinete.Rows[e.RowIndex].Cells[4].Value.ToString();
            direccion = dgv_Clinete.Rows[e.RowIndex].Cells[5].Value.ToString();
            fhecha = dgv_Clinete.Rows[e.RowIndex].Cells[6].Value.ToString();
            n_casa = dgv_Clinete.Rows[e.RowIndex].Cells[7].Value.ToString();

            txt_nombreCliente.Text = nombre;
            txt_apellidoCliente.Text = apellido;
            txt_rutCliente.Text = rut;
            txt_ciudadCliente.Text = ciudad;
            txt_direccionCliente.Text = direccion;
            //dTime_Cliente.Text = fhecha;
            txt_numeroCasaCliente.Text = n_casa;


        }

        //boton modificar los clientes

        private void bt_ModificarCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desas modificar", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Gestion modificar = new Gestion();


                    if (modificar.modificar_clientes(Convert.ToInt32(ID_cliente), txt_nombreCliente.Text, txt_apellidoCliente.Text, txt_rutCliente.Text, txt_ciudadCliente.Text, txt_direccionCliente.Text, dTime_Cliente.Text, txt_numeroCasaCliente.Text) > 0)
                    {


                        MessageBox.Show("Cliente modificado ...");
                        dgv_Clinete.Refresh();

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



        //-------------------------------------------------------------------------------------




        //agregar proveedor
        private void bt_guardarProveedor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desas agregar", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Gestion Agregar = new Gestion();


                    if (Agregar.agregar_proveedor(txt_nombreProveedor.Text, txt_contactoProveedor.Text, txt_cargoProveedor.Text, txt_direccionProveedor.Text, txt_numeroProveedor.Text, txt_ciudadProveedor.Text, txt_provinciaProveedor.Text, txt_paisProveedor.Text, txt_telefonoProveedor.Text, txt_celularProveedor.Text, txt_sitiowebProveedor.Text) > 0)
                    {


                        MessageBox.Show("Proveedor Agregado Exitosamente ...");


                    }
                    else
                    {
                        MessageBox.Show("Error Al Agregar Proveedor ...");
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }


        //envia la informacion del txt a la gestion dgv proveedor y cargar datos en la grilla proveedor
        private void txt_buscarProveedor_TextChanged(object sender, EventArgs e)
        {

            Gestion lista = new Gestion();

            dgv_Proveedor.DataSource = lista.cargarDGVproveedor(txt_buscarProveedor.Text);

        }

        public string ID_proveedor { get; set; }
        public string nombreProveedor { get; set; }
        public string contacto { get; set; }
        public string cargo { get; set; }
        public string direccionProveedor { get; set; }
        public string numero { get; set; }
        public string ciudadProveedor { get; set; }
        public string provincia { get; set; }
        public string pais { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        public string sitio_web { get; set; }


        //acer clic en la celda para devolver el valor proveedor
        private void dgv_Proveedor_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID_proveedor = dgv_Proveedor.Rows[e.RowIndex].Cells[0].Value.ToString();
            nombreProveedor = dgv_Proveedor.Rows[e.RowIndex].Cells[1].Value.ToString();
            contacto = dgv_Proveedor.Rows[e.RowIndex].Cells[2].Value.ToString();
            cargo = dgv_Proveedor.Rows[e.RowIndex].Cells[3].Value.ToString();
            direccionProveedor = dgv_Proveedor.Rows[e.RowIndex].Cells[4].Value.ToString();
            numero = dgv_Proveedor.Rows[e.RowIndex].Cells[5].Value.ToString();
            ciudadProveedor = dgv_Proveedor.Rows[e.RowIndex].Cells[6].Value.ToString();
            provincia = dgv_Proveedor.Rows[e.RowIndex].Cells[7].Value.ToString();
            pais = dgv_Proveedor.Rows[e.RowIndex].Cells[8].Value.ToString();
            telefono = dgv_Proveedor.Rows[e.RowIndex].Cells[9].Value.ToString();
            celular = dgv_Proveedor.Rows[e.RowIndex].Cells[10].Value.ToString();
            sitio_web = dgv_Proveedor.Rows[e.RowIndex].Cells[11].Value.ToString();

            txt_nombreProveedor.Text = nombreProveedor;
            txt_contactoProveedor.Text = contacto;
            txt_cargoProveedor.Text = cargo;
            txt_direccionProveedor.Text = direccion;
            txt_numeroProveedor.Text = numero;
            txt_ciudadProveedor.Text = ciudadProveedor;
            txt_provinciaProveedor.Text = provincia;
            txt_paisProveedor.Text = pais;
            txt_telefonoProveedor.Text = telefono;
            txt_celularProveedor.Text = celular;
            txt_sitiowebProveedor.Text = sitio_web;


        }
        // envia datos para modificar proveedores
        private void bt_modificarProveedor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desas modificar", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Gestion modificar = new Gestion();


                    if (modificar.modificar_proveedor(Convert.ToInt32(ID_proveedor), txt_nombreProveedor.Text, txt_contactoProveedor.Text, txt_cargoProveedor.Text, txt_direccionProveedor.Text, txt_numeroProveedor.Text, txt_ciudadProveedor.Text, txt_provinciaProveedor.Text, txt_paisProveedor.Text, txt_telefonoProveedor.Text, txt_celularProveedor.Text, txt_sitiowebProveedor.Text) > 0)
                    {


                        MessageBox.Show("Proveedor modificado ...");
                        dgv_Clinete.Refresh();

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




        //-------------------------------------------------------------------------------------




        //cargar combobox proveedores en productos
        public void cmb_provedorProductos()
        {
            //se declara una variable de tipo SqlConnection
            SqlConnection conexion = new SqlConnection();
            //se indica la cadena de conexion
            conexion.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ElfmanStrauss;Integrated Security=True";
            //código para llenar el comboBox
            DataSet ds = new DataSet();
            //indicamos la consulta en SQL
            SqlDataAdapter da = new SqlDataAdapter("select nombre from proveedores", conexion);
            //se indica el nombre de la tabla
            da.Fill(ds, "proveedores");
            cmb_provedorProducto.DataSource = ds.Tables[0].DefaultView;
            //se especifica el campo de la tabla
            cmb_provedorProducto.ValueMember = "nombre";

        }


        //agregar producto

        private void bt_guardarProducto_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Estas seguro que desas agregar", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    Gestion Agregar = new Gestion();



                    if (Agregar.agregar_productos(txt_nombreProducto.Text, txt_stockProducto.Text, cmb_provedorProducto.Text, Convert.ToInt32(txt_precioProducto.Text), txt_idfacturaProducto.Text, txt_descripcionProdicto.Text) > 0)
                    {


                        MessageBox.Show("Producto Agregado Exitosamente ...");


                    }
                    else
                    {
                        MessageBox.Show("Error Al Agregar Producto ...");
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }

        }


        //envia la informacion del txt a la gestion dgv producto y cargar datos en la grilla productos
        private void txt_buscarProducto_TextChanged(object sender, EventArgs e)
        {
            Gestion lista = new Gestion();

            dgv_producto.DataSource = lista.cargarDGVproductos(txt_buscarProducto.Text);


        }

        public string ID_producto { get; set; }
        public string nombreProducto { get; set; }
        public string stock { get; set; }
        public string ID_proveedorProducto { get; set; }
        public string precio { get; set; }
        public string ID_factura { get; set; }
        public string descripcion { get; set; }


        //acer clic en la celda para devolver el valor producto

        private void dgv_producto_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID_producto = dgv_producto.Rows[e.RowIndex].Cells[0].Value.ToString();
            nombreProducto = dgv_producto.Rows[e.RowIndex].Cells[1].Value.ToString();
            stock = dgv_producto.Rows[e.RowIndex].Cells[2].Value.ToString();
            ID_proveedorProducto = dgv_producto.Rows[e.RowIndex].Cells[3].Value.ToString();
            precio = dgv_producto.Rows[e.RowIndex].Cells[4].Value.ToString();
            ID_factura = dgv_producto.Rows[e.RowIndex].Cells[5].Value.ToString();
            descripcion = dgv_producto.Rows[e.RowIndex].Cells[6].Value.ToString();

            txt_nombreProducto.Text = nombreProducto;
            txt_stockProducto.Text = stock;
            cmb_provedorProducto.Text = ID_proveedorProducto;
            txt_precioProducto.Text = precio;
            txt_idfacturaProducto.Text = ID_factura;
            txt_descripcionProdicto.Text = descripcion;

            txt_nombreProducto.Enabled = false;
            txt_stockProducto.Enabled = true;
            cmb_provedorProducto.Enabled = false;
            txt_precioProducto.Enabled = true;
            txt_idfacturaProducto.Enabled = false;
            txt_descripcionProdicto.Enabled = false;

            bt_guardarProducto.Visible = false;

            bt_modificarProducto.Visible = true;


        }


        //boton nuevo hace modificables los txtbox
        private void bt_nuevoProducto_Click(object sender, EventArgs e)
        {
            //hacer editables
            txt_nombreProducto.Enabled = true;
            txt_stockProducto.Enabled = true;
            cmb_provedorProducto.Enabled = true;
            txt_precioProducto.Enabled = true;
            txt_idfacturaProducto.Enabled = true;
            txt_descripcionProdicto.Enabled = true;
            //botos visible
            bt_guardarProducto.Visible = true;
            //botosn invisible
            bt_modificarProducto.Visible = false;


            //limpiar textbox
            txt_nombreProducto.Text = null;
            txt_stockProducto.Text = null;
            cmb_provedorProducto.Text = null;
            txt_precioProducto.Text = null;
            txt_idfacturaProducto.Text = null;
            txt_descripcionProdicto.Text = null;

        }


        //envia los datos para modificar productos
        private void bt_modificarProducto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desas modificar", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Gestion modificar = new Gestion();


                    if (modificar.modificar_producto(Convert.ToInt32(ID_producto), txt_stockProducto.Text, Convert.ToInt32(txt_precioProducto.Text)) > 0)
                    {


                        MessageBox.Show("Producto modificado ...");
                        dgv_Clinete.Refresh();

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



        //--------------------------------- ventas -------------------------------------------------------------------


        //buscar clientes en la base de datos para agregar a la venta

        public static DataTable Buscar(string rut)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();

            conexion.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ElfmanStrauss;Integrated Security=True";

            string consulta = "SELECT ID_cliente, nombre, apellido FROM clientes WHERE rut= @rut"; //consulta

            //enviar consulta a la bdt
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@rut", rut);
            SqlDataAdapter adap = new SqlDataAdapter(comando);
            adap.Fill(dt);

            return dt;
        }


        //agregar clientes a los texbox en venta

        private void bt_agregarclienteVenta_Click(object sender, EventArgs e)
        {

            DataTable dt = Form1.Buscar(txt_rutclienteVenta.Text);//envio dato a buscar

            //si encuentra el dato guardo los datos en las variables
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                //guardo datos en variables

                txt_idclienteVenta.Text = Convert.ToString(row["ID_cliente"]);
                txt_nombreclienteVenta.Text = Convert.ToString(row["nombre"]);
                txt_apellidoclienteVenta.Text = Convert.ToString(row["apellido"]);


            }
            else
                MessageBox.Show("No Existe", "Registro");
        }


        //cargar combobox proveedores en productos
        public void cmb_vendedorVentas()
        {
            //se declara una variable de tipo SqlConnection
            SqlConnection conexion = new SqlConnection();
            //se indica la cadena de conexion
            conexion.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ElfmanStrauss;Integrated Security=True";
            //código para llenar el comboBox
            DataSet ds = new DataSet();
            //indicamos la consulta en SQL
            SqlDataAdapter da = new SqlDataAdapter("select rut from usuario", conexion);
            //se indica el nombre de la tabla
            da.Fill(ds, "usuario");
            cmb_rutvendedorVenta.DataSource = ds.Tables[0].DefaultView;
            //se especifica el campo de la tabla
            cmb_rutvendedorVenta.ValueMember = "rut";

        }

        //buscar vendedor(usuario) en la base de datos para agregar a la venta

        public static DataTable Buscar2(string rut)
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection();

            conexion.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ElfmanStrauss;Integrated Security=True";

            string consulta = "SELECT ID_usuario, nombre, rut FROM usuario WHERE rut= @rut"; //consulta

            //enviar consulta a la bdt
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@rut", rut);
            SqlDataAdapter adap = new SqlDataAdapter(comando);
            adap.Fill(dt);

            return dt;
        }

        //agregar vendedor(usuario) a los texbox en venta

        private void bt_agregarvendedorVenta_Click(object sender, EventArgs e)
        {
            DataTable dt = Form1.Buscar2(cmb_rutvendedorVenta.Text);//envio dato a buscar

            //si encuentra el dato guardo los datos en las variables
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                //guardo datos en variables

                txt_idvendedorVenta.Text = Convert.ToString(row["ID_usuario"]);
                txt_nombrevendedorVenta.Text = Convert.ToString(row["nombre"]);
                txt_rutvendedorVenta.Text = Convert.ToString(row["rut"]);


            }
            else
                MessageBox.Show("No Existe", "Registro");
        }


        //envia la informacion del txt a la gestion dgv producto y cargar datos en la grilla ventas
        private void txt_buscarproductoVenta_TextChanged(object sender, EventArgs e)
        {


            Gestion lista = new Gestion();

            dgv_buscarproductoVenta.DataSource = lista.cargarDGVproductos(txt_buscarproductoVenta.Text);


        }
        //limpiar los campos de la busqueda de productos en venta
        private void button3_Click(object sender, EventArgs e)
        {

            txt_buscarproductoVenta.Text = null;
            dgv_buscarproductoVenta.DataSource = null;

        }

        public string ID_productoVenta { get; set; }
        public string nombreVenta { get; set; }
        public string stockVenta { get; set; }
        public string ID_proveedorVenta { get; set; }
        public string precioVenta { get; set; }
        public string ID_facturaVenta { get; set; }
        public string descripcionVenta { get; set; }

        //enviar datos a dgv carrito
        int total = 0;

        private void dgv_buscarproductoVenta_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            ID_productoVenta = dgv_buscarproductoVenta.Rows[e.RowIndex].Cells[0].Value.ToString();
            nombreVenta = dgv_buscarproductoVenta.Rows[e.RowIndex].Cells[1].Value.ToString();
            stockVenta = dgv_buscarproductoVenta.Rows[e.RowIndex].Cells[2].Value.ToString();
            ID_proveedorVenta = dgv_buscarproductoVenta.Rows[e.RowIndex].Cells[3].Value.ToString();
            precioVenta = dgv_buscarproductoVenta.Rows[e.RowIndex].Cells[4].Value.ToString();
            ID_facturaVenta = dgv_buscarproductoVenta.Rows[e.RowIndex].Cells[5].Value.ToString();
            descripcionVenta = dgv_buscarproductoVenta.Rows[e.RowIndex].Cells[6].Value.ToString();


            DataTable dt = new DataTable(); //creas una tabla 
            dt.Columns.Add("ID_producto"); //le creas las columnas 
            dt.Columns.Add("nombre");
            dt.Columns.Add("precio");
            DataRow row = dt.NewRow(); //creas un registro 
            row["ID_producto"] = ID_productoVenta; //Le añadres un valor 
            row["nombre"] = nombreVenta;
            row["precio"] = precioVenta;
            dt.Rows.Add(row); //añades el registro a la tabla 
            dgv_carritoVenta.DataSource = dt; //añades la tabla al datagrid 
            dgv_carritoVenta.Update(); //actualizas 



            total = total + Convert.ToInt32(precioVenta);

            txt_totalVenta.Text = Convert.ToString(total);




        }
        //agregar venta (guardar en bdt)
        private void bt_guardarVenta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desas agregar", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string hora;
                Timer timer1 = new Timer();
                timer1.Start();


                hora = DateTime.Now.ToLongTimeString();

                try
                {
                    Gestion Agregar = new Gestion();



                    if (Agregar.agregar_venta(hora, DT_fechaVenta.Text, Convert.ToInt32(txt_idvendedorVenta.Text), Convert.ToInt32(txt_idclienteVenta.Text), Convert.ToInt32(txt_totalVenta.Text)) > 0)
                    {


                        MessageBox.Show("VENTA REALIZADA Exitosamente ...");

                        reporte rep = new reporte();
                        rep.Show();

                    }
                    else
                    {
                        MessageBox.Show("Error VENTA ...");
                    }
                }
                catch (Exception)
                {

                    throw;
                }


            }

        }

        private void bt_cancelarVenta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desas cancelar la venta...", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                dgv_carritoVenta.DataSource = null;
                txt_totalVenta.Text = null;
                txt_buscarproductoVenta.Text = null;
                dgv_buscarproductoVenta.DataSource = null;
                txt_apellidoclienteVenta.Text = null;
                txt_nombreclienteVenta.Text = null;
                txt_idclienteVenta.Text = null;
                txt_rutclienteVenta.Text = null;
                txt_rutvendedorVenta.Text = null;
                txt_nombrevendedorVenta.Text = null;
                txt_idvendedorVenta.Text = null;

            }

        }

        private void BT_SALIR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("cerrar sesión ...", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Principal prin = new Principal();
                prin.Show();

                MessageBox.Show("sesión cerrada...");

                this.Close();

            }

        }

        private void bt_salir1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("cerrar sesión ...", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Principal prin = new Principal();
                prin.Show();

                MessageBox.Show("sesión cerrada...");

                this.Close();

            }

        }

        private void bt_salir2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("cerrar sesión ...", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Principal prin = new Principal();
                prin.Show();

                MessageBox.Show("sesión cerrada...");

                this.Close();

            }

        }

        private void bt_salir3_Click(object sender, EventArgs e)
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
