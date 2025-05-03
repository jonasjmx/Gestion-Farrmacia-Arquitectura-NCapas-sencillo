using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteEntidad
    {
        public int Id { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        private List<FacturaEntidad> _listaFacturas;

        public List<FacturaEntidad> ListaFacturas
        {
            get 
            { 
                if (_listaFacturas == null)
                {
                    _listaFacturas = new List<FacturaEntidad>();
                }
                return _listaFacturas; 
            }
            set { _listaFacturas = value; }
        }


        public ClienteEntidad()
        {
        }

        public ClienteEntidad(int id, string apellido, string nombre, string cedula, string direccion, string telefono, string correo)
        {
            Id = id;
            Apellido = apellido;
            Nombre = nombre;
            Cedula = cedula;
            Direccion = direccion;
            Telefono = telefono;
            Correo = correo;
        }
    }
}
