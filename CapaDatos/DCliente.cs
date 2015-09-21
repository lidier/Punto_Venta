using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    class DCliente
    {

        private int id_cliente;
        private string nombreCliente;
        private string apellido1;

     
        private string apellido2;
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
        private string fechaNacimiento;
        private string textoBuscar;

      
        
        public string FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
       
        public string TextoBuscar
        {
            get { return textoBuscar; }
            set { textoBuscar = value; }
        }
        public int Id_cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }


        public string NombreCliente
        {
            get { return nombreCliente; }
            set { nombreCliente = value; }
        }


        //constructor vacio


        public DCliente() { }
        
        public DCliente(int idcliente, string nombre, string apellido, string fechaNacimiento, string texbuscar) {

            this.Id_cliente = idcliente;
            this.NombreCliente = nombre;
            this.Apellido1 = apellido1;
            this.Apellido2 = apellido2;
            this.FechaNacimiento = fechaNacimiento;
            this.TextoBuscar = texbuscar;
        
        }
    
    
    
    
    }
}
