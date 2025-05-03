using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class ClienteNegocio
    {
        public static ClienteEntidad BuscarClientePorCedula(string cedula)
        {
            return ClienteDatos.BuscarClientePorCedula(cedula);
        }

        public static ClienteEntidad BuscarClientePorId(int id)
        {
            return ClienteDatos.BuscarClientePorId(id);
        }

        public static ClienteEntidad DevolverFacturasCliente(ClienteEntidad cliente)
        {
            return ClienteDatos.DevolverFacturasCliente(cliente);
        }

        public static ClienteEntidad Guardar(ClienteEntidad cliente)
        {
            if (cliente.Id == 0)
            {
                return ClienteDatos.Nuevo(cliente);
            }
            else
            {
                return ClienteDatos.Actualizar(cliente);
            }
        }

        public static List<ClienteEntidad> ListaClientes()
        {
            return ClienteDatos.ListaClientes();
        }
    }
}
