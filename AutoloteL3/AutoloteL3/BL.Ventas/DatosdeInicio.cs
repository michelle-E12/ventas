using BL.Ventas;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Ventas
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {

            var usuarioAdmin1 = new Usuario();
            usuarioAdmin1.Nombre = "admin";
            usuarioAdmin1.Contrasena = "1234";

            contexto.Usuarios.Add(usuarioAdmin1);

            var usuarioAdmin2 = new Usuario();
            usuarioAdmin2.Nombre = "admin2";
            usuarioAdmin2.Contrasena = "0000";

            contexto.Usuarios.Add(usuarioAdmin2);

            var categoria1 = new Categoria();
            categoria1.Descripcion = "4x4";
            contexto.Categorias.Add(categoria1);

            var categoria2 = new Categoria();
            categoria2.Descripcion = "Automático";
            contexto.Categorias.Add(categoria2);

            var categoria3 = new Categoria();
            categoria3.Descripcion = "4x2";
            contexto.Categorias.Add(categoria3);

            var categoria4 = new Categoria();
            categoria4.Descripcion = "Mecánico";
            contexto.Categorias.Add(categoria4);

            base.Seed(contexto);
        }
    }
}