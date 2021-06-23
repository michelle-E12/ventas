using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Ventas
{
    public class ProductosBL
    {
        public BindingList<Producto> ListaProductos { get; set; }

        public ProductosBL()
        {
            ListaProductos = new BindingList<Producto>();

            var producto1 = new Producto();
            producto1.ID = 1;
            producto1.Descripcion = "BMW X6";
            producto1.Precio = 1580000;
            producto1.Existencia = 5;
            producto1.Activo = true;

            ListaProductos.Add(producto1);

            var producto2 = new Producto();
            producto2.ID = 2;
            producto2.Descripcion = "Ford Escape";
            producto2.Precio = 134990;
            producto2.Existencia = 2;
            producto2.Activo = true;

            ListaProductos.Add(producto2);

            var producto3 = new Producto();
            producto3.ID = 3;
            producto3.Descripcion = "Chevrolet Camaro";
            producto3.Precio = 42500;
            producto3.Existencia = 7;
            producto3.Activo = true;

            ListaProductos.Add(producto3);

            var producto4 = new Producto();
            producto4.ID = 4;
            producto4.Descripcion = "Toyota 4Runner";
            producto4.Precio = 43325;
            producto4.Existencia = 3;
            producto4.Activo = true;

            ListaProductos.Add(producto4);

            var producto5 = new Producto();
            producto5.ID = 5;
            producto5.Descripcion = "Honda Civic";
            producto5.Precio = 21900;
            producto5.Existencia = 8;
            producto5.Activo = true;

            ListaProductos.Add(producto5);

            var producto6 = new Producto();
            producto6.ID = 6;
            producto6.Descripcion = "Mazda Rx8";
            producto6.Precio = 60000;
            producto6.Existencia = 10;
            producto6.Activo = true;

            ListaProductos.Add(producto6);
        }

        public BindingList<Producto> ObtenerProductos()
        {
            return ListaProductos;
        }
    }

    public class Producto
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }
    }
}
