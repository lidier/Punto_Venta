using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    class DEmpleado
    {
        private int idEmpleado;
        private string nombreEmpleado;
        private string apellido1;
        private string apellido2;
        private string estado;
        private string textoBuscar;

        public int IdEmpleado
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }

        public string NombreEmpleado
        {
            get { return nombreEmpleado; }
            set { nombreEmpleado = value; }
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

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string TextoBuscar
        {
            get { return textoBuscar; }
            set { textoBuscar = value; }
        }

        public string insertar(DEmpleado empleado)
        {
            string rstp = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlcon;
                sqlCmd.CommandText = "pa_insertarEmpleado"; 
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEmpleado = new SqlParameter();
                ParIdEmpleado.ParameterName = "@idEmpleado";
                ParIdEmpleado.SqlDbType = SqlDbType.Int;
                ParIdEmpleado.Value = empleado.IdEmpleado;
                sqlCmd.Parameters.Add(ParIdEmpleado);

                SqlParameter ParNombreEmpleado = new SqlParameter();
                ParNombreEmpleado.ParameterName = "@nombreEmpleado";
                ParNombreEmpleado.SqlDbType = SqlDbType.VarChar;
                ParNombreEmpleado.Size = 15;
                ParNombreEmpleado.Value = empleado.NombreEmpleado;
                sqlCmd.Parameters.Add(ParNombreEmpleado);


                SqlParameter ParApellido1 = new SqlParameter();
                ParApellido1.ParameterName = "@apellido1";
                ParApellido1.SqlDbType = SqlDbType.VarChar;
                ParApellido1.Size = 20;
                ParApellido1.Value = empleado.Apellido1;
                sqlCmd.Parameters.Add(ParApellido1);

                SqlParameter ParApellido2 = new SqlParameter();
                ParApellido2.ParameterName = "@apellido2";
                ParApellido2.SqlDbType = SqlDbType.VarChar;
                ParApellido2.Size = 20;
                ParApellido2.Value = empleado.Apellido2;
                sqlCmd.Parameters.Add(ParApellido2);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 30;
                ParEstado.Value = empleado.Estado;
                sqlCmd.Parameters.Add(ParEstado);

                rstp = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se inserto el Empleado";


            }

            catch (Exception ex)
            {
                rstp = ex.Message;
            }

            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }

            return rstp;
        }

        public string Modificar(DEmpleado empleado)
        {
            string rstp = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlcon;
                sqlCmd.CommandText = "pa_modificarEmpleado";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEmpleado = new SqlParameter();
                ParIdEmpleado.ParameterName = "@idEmpleado";
                ParIdEmpleado.SqlDbType = SqlDbType.Int;
                ParIdEmpleado.Value = empleado.IdEmpleado;
                sqlCmd.Parameters.Add(ParIdEmpleado);

                SqlParameter ParNombreEmpleado = new SqlParameter();
                ParNombreEmpleado.ParameterName = "@nombreEmpleado";
                ParNombreEmpleado.SqlDbType = SqlDbType.VarChar;
                ParNombreEmpleado.Size = 15;
                ParNombreEmpleado.Value = empleado.NombreEmpleado;
                sqlCmd.Parameters.Add(ParNombreEmpleado);


                SqlParameter ParApellido1 = new SqlParameter();
                ParApellido1.ParameterName = "@apellido1";
                ParApellido1.SqlDbType = SqlDbType.VarChar;
                ParApellido1.Size = 20;
                ParApellido1.Value = empleado.Apellido1;
                sqlCmd.Parameters.Add(ParApellido1);

                SqlParameter ParApellido2 = new SqlParameter();
                ParApellido2.ParameterName = "@apellido2";
                ParApellido2.SqlDbType = SqlDbType.VarChar;
                ParApellido2.Size = 20;
                ParApellido2.Value = empleado.Apellido2;
                sqlCmd.Parameters.Add(ParApellido2);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 30;
                ParEstado.Value = empleado.Estado;
                sqlCmd.Parameters.Add(ParEstado);

                rstp = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Modifico el Empleado";


            }

            catch (Exception ex)
            {
                rstp = ex.Message;
            }

            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }

            return rstp;
        }

        public string Eliminar( DEmpleado empleado)
        {
            string rstp = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlcon;
                sqlCmd.CommandText = "pa_eliminarEmpleado";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEmpleado = new SqlParameter();
                ParIdEmpleado.ParameterName = "@idEmpleado";
                ParIdEmpleado.SqlDbType = SqlDbType.Int;
                ParIdEmpleado.Value = empleado.IdEmpleado;
                sqlCmd.Parameters.Add(ParIdEmpleado);

                rstp = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Elimino el Empleado";

            }

            catch (Exception ex)
            {
                rstp = ex.Message;
            }

            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }

            return rstp;
        }

        public DataTable mostrar()
        {

        }
    }
}
