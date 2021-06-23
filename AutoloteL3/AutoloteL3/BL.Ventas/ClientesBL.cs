using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Ventas
{
    public class ClientesBL
    {
        public BindingList<Cliente> ListaClientes { get; set; }

        public ClientesBL()
        {
            ListaClientes = new BindingList<Cliente>();

            var cliente1 = new Cliente();
            cliente1.Codigo = 1;
            cliente1.Nombre = "Michelle Romero";
            cliente1.Identidad = "0501-1995-04489";
            cliente1.Telefono = "8838-2239";
            cliente1.Direccion = "Col. Rio de Piedra, San Pedro Sula, Cortes";
            cliente1.Activo = true;

            ListaClientes.Add(cliente1);

            var cliente2 = new Cliente();
            cliente2.Codigo = 2;
            cliente2.Nombre = "Andrea Espinoza";
            cliente2.Identidad = "0801-1993-05479";
            cliente2.Telefono = "9990-6581";
            cliente2.Direccion = "Res. Los Prados, Choloma, Cortes";
            cliente2.Activo = true;

            ListaClientes.Add(cliente2);

            var cliente3 = new Cliente();
            cliente3.Codigo = 3;
            cliente3.Nombre = "Cristian Santos";
            cliente3.Identidad = "0401-1977-00389";
            cliente3.Telefono = "3220-0975";
            cliente3.Direccion = "Res. Villa Florencia, San Pedro Sula, Cortes";
            cliente3.Activo = true;

            ListaClientes.Add(cliente3);

            var cliente4 = new Cliente();
            cliente4.Codigo = 4;
            cliente4.Nombre = "Andres Altamirano";
            cliente4.Identidad = "0502-1999-05489";
            cliente4.Telefono = "9757-1750";
            cliente4.Direccion = "Bo. El Centro, Choloma, Cortes";
            cliente4.Activo = true;

            ListaClientes.Add(cliente4);
        }

        public BindingList<Cliente> ObtenerClientes()
        {
            return ListaClientes;
        }
    }

    public class Cliente
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Identidad { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }
    }
}
