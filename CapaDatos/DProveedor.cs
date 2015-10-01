using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DProveedor
    {
        private int idProveedor;
        private string nombre_comercial;
        private string nombre_proveedor;
        private string apellido1;
        private string apellido2;

        private string _TextoBuscar;

        public int IdProveedor
        {
            get { return idProveedor; }
            set { idProveedor = value; }
        }

        public string Nombre_proveedor
        {
            get { return nombre_proveedor; }
            set { nombre_proveedor = value; }
        }

        public string Apellido1
        {
            get { return apellido1; }
            set { apellido1 = value; }
        }

        public string Apellido2
        {
            get { return apellido2; }
            set { apellido2 = value; }
        }

        public string Fombre_comercial
        {
            get { return nombre_comercial; }
            set { nombre_comercial = value; }
        }
        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }
        //constructor vacio
        public DProveedor()
        {
        }
        //constructor con parametros
        public DProveedor(int idProveedor, string nombre_comercial, string nombre_proveedor, string apellido1, string apellido2, string _TextoBuscar)
        {
            this.idProveedor = idProveedor;
            this.nombre_proveedor = nombre_proveedor;
            this.nombre_comercial = nombre_comercial;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this._TextoBuscar = _TextoBuscar;
        }

        //metodo insertar

        public string insertar(DProveedor proveedor)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pa_insertarProveedores";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdProveedor = new SqlParameter();
                ParIdProveedor.ParameterName = "@proveedorId";
                ParIdProveedor.SqlDbType = SqlDbType.Int;
                ParIdProveedor.Value = proveedor.idProveedor;
                SqlCmd.Parameters.Add(ParIdProveedor);

                SqlParameter ParNombreComercial = new SqlParameter();
                ParNombreComercial.ParameterName = "@nombreComercial";
                ParNombreComercial.SqlDbType = SqlDbType.VarChar;
                ParNombreComercial.Size = 20;
                ParNombreComercial.Value = proveedor.nombre_comercial;
                SqlCmd.Parameters.Add(ParNombreComercial);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 15;
                ParNombre.Value = proveedor.nombre_proveedor;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido1 = new SqlParameter();
                ParApellido1.ParameterName = "@apellido1";
                ParApellido1.SqlDbType = SqlDbType.VarChar;
                ParApellido1.Size = 20;
                ParApellido1.Value = proveedor.apellido1;
                SqlCmd.Parameters.Add(ParApellido1);

                SqlParameter ParApellido2 = new SqlParameter();
                ParApellido2.ParameterName = "@apellido2";
                ParApellido2.SqlDbType = SqlDbType.VarChar;
                ParApellido2.Size = 20;
                ParApellido2.Value = proveedor.apellido2;
                SqlCmd.Parameters.Add(ParNombreComercial);

                //ejecutar
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "No se ingreso registro";

            }
            catch (Exception ex)
            {

                rpta = ex.Message;
            }
            finally
            {

                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();

            }
            return rpta;
        }
        //metodo editar
        
        public string editar(DProveedor proveedor)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pa_editarProveedores";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdProveedor = new SqlParameter();
                ParIdProveedor.ParameterName = "@proveedorId";
                ParIdProveedor.SqlDbType = SqlDbType.Int;
                ParIdProveedor.Value = proveedor.idProveedor;
                SqlCmd.Parameters.Add(ParIdProveedor);

                SqlParameter ParNombreComercial = new SqlParameter();
                ParNombreComercial.ParameterName = "@nombreComercial";
                ParNombreComercial.SqlDbType = SqlDbType.VarChar;
                ParNombreComercial.Size = 20;
                ParNombreComercial.Value = proveedor.nombre_comercial;
                SqlCmd.Parameters.Add(ParNombreComercial);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 15;
                ParNombre.Value = proveedor.nombre_proveedor;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParApellido1 = new SqlParameter();
                ParApellido1.ParameterName = "@apellido1";
                ParApellido1.SqlDbType = SqlDbType.VarChar;
                ParApellido1.Size = 20;
                ParApellido1.Value = proveedor.apellido1;
                SqlCmd.Parameters.Add(ParApellido1);

                SqlParameter ParApellido2 = new SqlParameter();
                ParApellido2.ParameterName = "@apellido2";
                ParApellido2.SqlDbType = SqlDbType.VarChar;
                ParApellido2.Size = 20;
                ParApellido2.Value = proveedor.apellido2;
                SqlCmd.Parameters.Add(ParNombreComercial);

                //ejecutar
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "No se actualizo registro";

            }
            catch (Exception ex)
            {

                rpta = ex.Message;
            }
            finally
            {

                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();

            }
            return rpta;
        }
        
        //metodo eliminar

        public string eliminar(DProveedor proveedor)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pa_eliminarProveedores";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdProveedor = new SqlParameter();
                ParIdProveedor.ParameterName = "@proveedorId";
                ParIdProveedor.SqlDbType = SqlDbType.Int;
                ParIdProveedor.Value = proveedor.idProveedor;
                SqlCmd.Parameters.Add(ParIdProveedor);

                SqlParameter ParNombreComercial = new SqlParameter();
                ParNombreComercial.ParameterName = "@nombreComercial";
                ParNombreComercial.SqlDbType = SqlDbType.VarChar;
                ParNombreComercial.Size = 20;
                ParNombreComercial.Value = proveedor.nombre_comercial;
                SqlCmd.Parameters.Add(ParNombreComercial);

                //ejecutar
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "No se actualizo registro";

            }
            catch (Exception ex)
            {

                rpta = ex.Message;
            }
            finally
            {

                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();

            }
            return rpta;
        }
        
        //metodo mostrar

        public DataTable mostrar()
        {
         DataTable DtResultado = new DataTable("proveedor");
        SqlConnection SqlCon = new SqlConnection();
        try
        {
            //1. Establecer la cadena de conexion
            SqlCon.ConnectionString = Conexion.Cn;

            //2. Establecer el comando
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;//La conexión que va a usar el comando
            SqlCmd.CommandText = "pa_";//El comando a ejecutar
            SqlCmd.CommandType = CommandType.StoredProcedure;
            //Decirle al comando que va a ejecutar una sentencia SQL

            //3. No hay parámetros

            //4. El DataAdapter que va a ejecutar el comando y
            //es el encargado de llena el DataTable
            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);//Llenamos el DataTable
        }
        catch (Exception ex)
        {
            DtResultado = null;
           
        }
        return DtResultado; 

        }
        public DataTable buscarNombre(DProveedor proveedor)
        {
            DataTable DtResultado = new DataTable("categoria");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //1. Establecer la cadena de conexion
                SqlCon.ConnectionString = Conexion.Cn;

                //2. Establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;//La conexión que va a usar el comando
                SqlCmd.CommandText = "pa";//El comando a ejecutar
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //Decirle al comando que va a ejecutar una sentencia SQL

                //3.Enviamos wl parámetro de Búsqueda
                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = proveedor.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                //4. El DataAdapter que va a ejecutar el comando y
                //es el encargado de llena el DataTable
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);//Llenamos el DataTable
            }
            catch (Exception ex)
            {
                DtResultado = null;
                ex.ToString();

            }
            return DtResultado;
        }
     
    }
}
