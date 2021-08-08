using BL.Ventas;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Ventas
{
    public class Contexto : DbContext
    {

        public Contexto() : base("Server=unah-devs.clyyjeqs85lp.us-east-1.rds.amazonaws.com,1433;Database=unah-devs;User Id=admin; Password=UNAH%123;")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio()); // Agrega datos de inicio a la base de datos despues de eliminarla
            modelBuilder.Types().Configure(entity => entity.ToTable("AutoloteL3_" + entity.ClrType.Name));
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
