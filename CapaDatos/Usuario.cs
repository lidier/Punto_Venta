using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Usuario
    {

        /*private string usuario;
        private string password;

        public Usuario()
        {
            usuario = string.Empty;
            password = string.Empty;
            this.sql = string.Empty;
        }

        public string Usuarios
        {
            get { return this.usuario; }
            set { this.usuario = value; }
        }

        public string Contraseña
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public bool buscar()
        {
            bool resultado = false;
            this.sql = string.Format(@"SELECT idUsuario FROM USUARIOS WHERE nick = '{0}' AND contrasena= '{1}'", this.usuario, this.password);
            this.comando = new SqlCommand(this.sql, this.cnn);
            this.cnn.Open();
            SqlDataReader reg = null;
            reg = this.comando.ExecuteReader();
            if (reg.Read())
            {
                resultado = true;
                this.mensaja = "Bienvenido, Acesso Aprovado";

            }
            else
            {
                this.mensaja = "Datos Incorecctos, Por favor verifique";

            }
            this.cnn.Close();
            return resultado;

        }*/
    }
}
