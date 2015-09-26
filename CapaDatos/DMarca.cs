using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class DMarca
    {
        private int idMarca;
        private string nombre_marca;
        //private Image imagen_marca;
        private string _TextoBuscar;

        public int IdMarca
        {
            get { return idMarca; }
            set { idMarca = value; }
        }
        public string Nombre_marca
        {
            get { return nombre_marca; }
            set { nombre_marca = value; }
        }

        public DMarca()
        {
        }
        public DMarca(int idMarca,string nombre_marca,string _TextoBuscar) 
        {
            this.idMarca = idMarca;
            this.nombre_marca = nombre_marca;
            this._TextoBuscar = _TextoBuscar;
        }
        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }

        public string insertar(DMarca marca)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pa_insertar_marca";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdMarca = new SqlParameter();
                ParIdMarca.ParameterName = "@idmarca";
                ParIdMarca.SqlDbType = SqlDbType.Int;
                ParIdMarca.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdMarca);

                SqlParameter ParNombreMarca = new SqlParameter();
                ParNombreMarca.ParameterName = "@nombre_marca";
                ParNombreMarca.SqlDbType = SqlDbType.VarChar;
                ParNombreMarca.Size = 20;
                ParNombreMarca.Value = marca.nombre_marca;
                SqlCmd.Parameters.Add(ParNombreMarca);

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
        public string editar(DMarca marca)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pa_editar_marca";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdMarca = new SqlParameter();
                ParIdMarca.ParameterName = "@idmarca";
                ParIdMarca.SqlDbType = SqlDbType.Int;
                ParIdMarca.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdMarca);

                SqlParameter ParNombreMarca = new SqlParameter();
                ParNombreMarca.ParameterName = "@nombre_marca";
                ParNombreMarca.SqlDbType = SqlDbType.VarChar;
                ParNombreMarca.Size = 20;
                ParNombreMarca.Value = marca.nombre_marca;
                SqlCmd.Parameters.Add(ParNombreMarca);

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

     /*   public string eliminar(DMarca marca) {

            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "pa_editar_marca";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdMarca = new SqlParameter();
                ParIdMarca.ParameterName = "@idmarca";
                ParIdMarca.SqlDbType = SqlDbType.Int;
                ParIdMarca.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdMarca);

                SqlParameter ParNombreMarca = new SqlParameter();
                ParNombreMarca.ParameterName = "@nombre_marca";
                ParNombreMarca.SqlDbType = SqlDbType.VarChar;
                ParNombreMarca.Size = 20;
                ParNombreMarca.Value = marca.nombre_marca;
                SqlCmd.Parameters.Add(ParNombreMarca);

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
    */}
}
