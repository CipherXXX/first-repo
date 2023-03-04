using Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class CatalogContext : DbContext
    {
        public CatalogContext()
            : base("name=CatalogContext")
        {

        }
       public DbSet<Movie> Movies { get; set; }
      public DbSet<Series> Serials { get; set; }

     
    }
}
