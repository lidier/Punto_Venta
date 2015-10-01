using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    class Telefono
    {

        private int idCliente;
        private int idEmpleado;
        private int telefono;
        
        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        } 
        public int IdEmpleado
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }
        public int _Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string insertar(Telefono tel)
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
                ParIdEmpleado.Value = tel.IdCliente;
                sqlCmd.Parameters.Add(ParIdEmpleado);

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@idEmpleado";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = tel.IdEmpleado;
                sqlCmd.Parameters.Add(ParIdCliente);


                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.Int;
                ParTelefono.Value = tel.telefono;
                sqlCmd.Parameters.Add(ParTelefono);

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

        public string Modificar(Telefono tel)
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
                ParIdEmpleado.Value = tel.IdCliente;
                sqlCmd.Parameters.Add(ParIdEmpleado);

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@idEmpleado";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = tel.IdEmpleado;
                sqlCmd.Parameters.Add(ParIdCliente);


                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.Int;
                ParTelefono.Value = tel.telefono;
                sqlCmd.Parameters.Add(ParTelefono);

                rstp = sqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se edito el telefono";


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

        public string Eliminar(DEmpleado empleado)
        {
            string rstp = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlcon;
                sqlCmd.CommandText = "pa_eliminarTelefono";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdEmpleado = new SqlParameter();
                ParIdEmpleado.ParameterName = "@idTelefono";
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

    }
}

