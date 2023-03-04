using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
   public class ViewModelCatalog
    {
        public IEnumerable<Movie> MovieModelView { get; set; }
        public IEnumerable<Series> SeriesModelView { get; set; }
    }
}
