using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.ClasesDB
{
    public  class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Context>();

            // Configura la conexión a tu base de datos
            optionsBuilder.UseSqlServer(
                "Data Source=DESKTOP-K7L1ARV;Initial Catalog=SaludPlus;Integrated Security=True;TrustServerCertificate=True");

            return new Context(optionsBuilder.Options);
        }


    }
}
