using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
     public  class DClientes
    {
        private int idCliente;
        private string nombreCliente;
        private string apellido1;
        private string apellido2;
        private DateTime fechaNacimiento;
        private int estado;
        private string textoBuscar;

        public int id_Cliente {

            get { return idCliente; }
            set { idCliente=value; }
        }

        public string NombreCliente
        {
            get { return nombreCliente;}

            set { nombreCliente = value;}
        }

        public string Apellido1
        {
            get {return apellido1;}

            set {apellido1 = value;}
        }

        public string Apellido2
        {
            get { return apellido2; }
            set { apellido2 = value; }
        }

        public DateTime Fecha
        {
            get {return fechaNacimiento;}
            set { fechaNacimiento = value; }
        }

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string TextoBuscar
        {
            get { return textoBuscar; }
            set { textoBuscar = value; }
        }

        //construtor Vacio
        public DClientes()
        {
        }

        public DClientes(int idCliente, string nombreCliente, string apellido1, string apellido2, DateTime fechaNacimiento, string estado)
        {
            this.id_Cliente = idCliente;
            this.NombreCliente = nombreCliente;
            this.Apellido1 = apellido1;
            this.Apellido2 = apellido2;
            this.Fecha = fechaNacimiento;
            this.Estado = estado;
        }

        //Metodo Insertar
        public string Insertar(DClientes cliente)
        {
            string rspt = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {   //codigo de conexion
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                // codigo del comando de insertar
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlcon;
                sqlCmd.CommandText = "pa_insertarCliente";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@clienteId";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = cliente.id_Cliente;
                sqlCmd.Parameters.Add(ParIdCliente);

                SqlParameter ParNombreCliente = new SqlParameter();
                ParNombreCliente.ParameterName = "@nombre";
                ParNombreCliente.SqlDbType = SqlDbType.VarChar;
                ParNombreCliente.Size = 15;
                ParNombreCliente.Value = cliente.NombreCliente;
                sqlCmd.Parameters.Add(ParNombreCliente);

                SqlParameter ParApellido1 = new SqlParameter();
                ParApellido1.ParameterName = "@apellido1";
                ParApellido1.SqlDbType = SqlDbType.VarChar;
                ParApellido1.Size = 20;
                ParApellido1.Value = cliente.Apellido1;
                sqlCmd.Parameters.Add(ParApellido1);

                SqlParameter ParApellido2 = new SqlParameter();
                ParApellido2.ParameterName = "@apellido2";
                ParApellido2.SqlDbType = SqlDbType.VarChar;
                ParApellido2.Size = 20;
                ParApellido2.Value = cliente.Apellido2;
                sqlCmd.Parameters.Add(ParApellido2);

                SqlParameter ParFechaNacimiento = new SqlParameter();
                ParFechaNacimiento.ParameterName = "@fechaNacimiento";
                ParFechaNacimiento.SqlDbType = SqlDbType.Date;
                ParFechaNacimiento.Value = cliente.Fecha;
                sqlCmd.Parameters.Add(ParFechaNacimiento);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.Int;
                ParEstado.Value = cliente.Estado;
                sqlCmd.Parameters.Add(ParEstado);

                rspt = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el Cliente";

            }
            catch (Exception ex)
            {
                rspt = ex.Message;
            }

            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }

            return rspt;
        }

        //Metodo modificar
        public string Editar(DClientes cliente)
        {
            string rspt = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {   //codigo de conexion
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                // codigo del comando de insertar
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlcon;
                sqlCmd.CommandText = "pa_actualizarCliente";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@clienteId";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = cliente.id_Cliente;
                sqlCmd.Parameters.Add(ParIdCliente);

                SqlParameter ParNombreCliente = new SqlParameter();
                ParNombreCliente.ParameterName = "@nombre";
                ParNombreCliente.SqlDbType = SqlDbType.VarChar;
                ParNombreCliente.Size = 15;
                ParNombreCliente.Value = cliente.NombreCliente;
                sqlCmd.Parameters.Add(ParNombreCliente);

                SqlParameter ParApellido1 = new SqlParameter();
                ParApellido1.ParameterName = "@apellido1";
                ParApellido1.SqlDbType = SqlDbType.VarChar;
                ParApellido1.Size = 20;
                ParApellido1.Value = cliente.Apellido1;
                sqlCmd.Parameters.Add(ParApellido1);

                SqlParameter ParApellido2 = new SqlParameter();
                ParApellido2.ParameterName = "@apellido2";
                ParApellido2.SqlDbType = SqlDbType.VarChar;
                ParApellido2.Size = 20;
                ParApellido2.Value = cliente.Apellido2;
                sqlCmd.Parameters.Add(ParApellido2);

                SqlParameter ParFechaNacimiento = new SqlParameter();
                ParFechaNacimiento.ParameterName = "@fechaNacimiento";
                ParFechaNacimiento.SqlDbType = SqlDbType.Date;
                ParFechaNacimiento.Value = cliente.Fecha;
                sqlCmd.Parameters.Add(ParFechaNacimiento);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.Int;
                ParEstado.Value = cliente.Estado;
                sqlCmd.Parameters.Add(ParEstado);

                rspt = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizo el Cliente";

            }
            catch (Exception ex)
            {
                rspt = ex.Message;
            }

            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }

            return rspt;
        }

        //Metodo Eliminar
        public string Eliminar(DClientes cliente)
        {
            string rspt = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {   //codigo de conexion
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                // codigo del comando de insertar
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlcon;
                sqlCmd.CommandText = "pa_eliminarCliente";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@clienteId";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = cliente.id_Cliente;
                sqlCmd.Parameters.Add(ParIdCliente);

              

                rspt = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Elimino el Cliente";

            }
            catch (Exception ex)
            {
                rspt = ex.Message;
            }

            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }

            return rspt;
        }

        //Metodo mostrar
        public DataTable Mostrar()
        {
            DataTable tablaResultado = new DataTable("Clientes");
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlcon;
                sqlCmd.CommandText = "pa_mostrarCliente";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCmd);
                sqlData.Fill(tablaResultado);
            }
            catch (Exception ex)
            {
                tablaResultado = null;
            }

            return tablaResultado;
        }

        //Metodo Buscar
        public DataTable BuscarNombre(DClientes cliente)
        {
            DataTable tablaResultado = new DataTable("Clientes");
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlcon;
                sqlCmd.CommandText = "pa_mostrarCliente";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBuscarCliente = new SqlParameter();
                ParBuscarCliente.ParameterName = "@textoBuscar";
                ParBuscarCliente.SqlDbType = SqlDbType.VarChar;
                ParBuscarCliente.Size = 50;
                ParBuscarCliente.Value = cliente.TextoBuscar;
                sqlCmd.Parameters.Add(ParBuscarCliente);

                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCmd);
                sqlData.Fill(tablaResultado);
            }
            catch (Exception ex)
            {
                tablaResultado = null;
            }

            return tablaResultado;
        }

    }
}
