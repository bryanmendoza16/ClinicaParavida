using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ClinicaParavida.Data
{
    public class ClinicaParavidaContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ClinicaParavidaContext() : base("name=ClinicaParavidaContext")
        {
        }

        public System.Data.Entity.DbSet<ClinicaParavida.Models.Cita> Citas { get; set; }

        public System.Data.Entity.DbSet<ClinicaParavida.Models.Enfermera> Enfermeras { get; set; }

        public System.Data.Entity.DbSet<ClinicaParavida.Models.Usuario> Usuarios { get; set; }
    }
}
