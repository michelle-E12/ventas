using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Ventas
{
    public class SeguridadBL
    {
        public bool Autorizar(string usuario, string contrasena)
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
    }
}
