using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Ventas
{
    public class SeguridadBL
    {
        Contexto _contexto;

        public SeguridadBL()
        {
            _contexto = new Contexto();
        }

        public bool Autorizar(string usuario, string contrasena)
        {
            var usuarios = _contexto.Usuarios.ToList();

            foreach (var usuarioDB in usuarios)
            {
                if (usuario == usuarioDB.Nombre && contrasena == usuarioDB.Contrasena)
                {
                    return true;
                }
            }

            return false;
        }
    }

    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
    }

    /*public bool Autorizar(string usuario, string contrasena)
    {

        if (usuario == "admin" && contrasena == "1234")
        {
            return true;
        }
        else
        {
            if (usuario == "admin2" && contrasena == "0000")
            {
                return true;
            }
        }

        return false;
    }
}*/
}
