using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NCliente
    {
        public string insertar(int idCliente, string nombreCliente, string apellido1, string apellido2, DateTime nacimiento, int estado)
        {
            DClientes obj = new DClientes();
            obj.id_Cliente = idCliente;
            obj.NombreCliente = nombreCliente;
            obj.Apellido1 = apellido1;
            obj.Apellido2 = apellido2;
            obj.Fecha = nacimiento;
            obj.Estado = estado;

            return obj.Insertar(obj);
        }

        public string modificar(int idCliente, string nombreCliente, string apellido1, string apellido2, DateTime nacimiento, int estado)
        {
            DClientes obj = new DClientes();
            obj.id_Cliente = idCliente;
            obj.NombreCliente = nombreCliente;
            obj.Apellido1 = apellido1;
            obj.Apellido2 = apellido2;
            obj.Fecha = nacimiento;
            obj.Estado = estado;

            return obj.Editar(obj);
        }

        public string eliminar(int idCliente)
        {
            DClientes obj = new DClientes();
            obj.id_Cliente = idCliente;

            return obj.Eliminar(obj);
        }

        public DataTable mostrar()
        {
            return new DClientes
        }

    }
}
