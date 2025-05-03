using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class ClienteDatos
    {
        public static ClienteEntidad BuscarClientePorCedula(string cedula)
		{
			try
			{
				ClienteEntidad cliente = new ClienteEntidad();
				Cliente clienteLINQ = new Cliente();
				using (DataClasses1DataContext context = new DataClasses1DataContext())
				{
                    clienteLINQ = context.Cliente.FirstOrDefault(x => x.cedula == cedula.ToString());

					if (clienteLINQ == null)
                        return null;

                    cliente.Id = clienteLINQ.id;
                    cliente.Cedula = clienteLINQ.cedula;
                    cliente.Nombre = clienteLINQ.nombre;
                    cliente.Apellido = clienteLINQ.apellido;
                    cliente.Direccion = clienteLINQ.direccion;
                    cliente.Telefono = clienteLINQ.telefono;
                    cliente.Correo = clienteLINQ.correo;
                }
                return cliente;
			}
			catch (Exception)
			{
				return null;
			}
        }
        public static ClienteEntidad Nuevo(ClienteEntidad cliente)
        {
            try
            {
                Cliente clienteLINQ = new Cliente();

                clienteLINQ.telefono = cliente.Telefono;
                clienteLINQ.cedula = cliente.Cedula;
                clienteLINQ.correo = cliente.Correo;
                clienteLINQ.apellido = cliente.Apellido;
                clienteLINQ.direccion = cliente.Direccion;
                clienteLINQ.nombre = cliente.Nombre;

                using (DataClasses1DataContext context = new DataClasses1DataContext())
                {
                    context.Cliente.InsertOnSubmit(clienteLINQ);
                    context.SubmitChanges();
                }
                cliente.Id = clienteLINQ.id;
                return cliente;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static ClienteEntidad Actualizar(ClienteEntidad cliente)
        {
            try
            {
                using (DataClasses1DataContext context = new DataClasses1DataContext())
                {
                    var clienteLINQ = context.Cliente.FirstOrDefault(x => x.id == cliente.Id);

                    clienteLINQ.telefono = cliente.Telefono;
                    clienteLINQ.cedula = cliente.Cedula;
                    clienteLINQ.correo = cliente.Correo;
                    clienteLINQ.apellido = cliente.Apellido;
                    clienteLINQ.direccion = cliente.Direccion;
                    clienteLINQ.nombre = cliente.Nombre;
                    context.SubmitChanges();
                }
                return cliente;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static ClienteEntidad DevolverFacturasCliente(ClienteEntidad cliente)
        {
            try
            {
                cliente = BuscarClientePorCedula(cliente.Cedula);
                if (cliente == null)
                    return null;

                cliente.ListaFacturas = FacturaDatos.DevolverFacturasCliente(cliente.Id);
                
                return cliente;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static ClienteEntidad BuscarClientePorId(int id)
        {
            try
            {
                ClienteEntidad cliente = new ClienteEntidad();
                Cliente clienteLINQ = new Cliente();
                using (DataClasses1DataContext context = new DataClasses1DataContext())
                {
                    clienteLINQ = context.Cliente.FirstOrDefault(x => x.id == id);

                    if (clienteLINQ == null)
                        return null;

                    cliente.Id = clienteLINQ.id;
                    cliente.Cedula = clienteLINQ.cedula;
                    cliente.Nombre = clienteLINQ.nombre;
                    cliente.Apellido = clienteLINQ.apellido;
                    cliente.Direccion = clienteLINQ.direccion;
                    cliente.Telefono = clienteLINQ.telefono;
                    cliente.Correo = clienteLINQ.correo;
                }
                return cliente;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<ClienteEntidad> ListaClientes()
        {
            try
            {
                List<ClienteEntidad> listaClientes = new List<ClienteEntidad>();

                List<Cliente> listaLINQ = new List<Cliente>();

                using (DataClasses1DataContext context = new DataClasses1DataContext())
                {
                    var resultado = from c in context.Cliente select c;
                    listaLINQ = resultado.ToList();
                }

                foreach (var item in listaLINQ)
                {
                    listaClientes.Add(new ClienteEntidad(item.id, item.apellido, item.nombre, item.cedula, item.direccion, item.telefono, item.correo));
                }
                return listaClientes;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
