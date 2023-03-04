using Data;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CatalogBusiness
    {
        //Movies
        private CatalogContext catalogContext;

        public List<Movie> GetAllMovies()
        {
            using (catalogContext = new CatalogContext())
            {
                return catalogContext.Movies.ToList();
            }
        }

        public Movie GetMovies(int id)
        {
            using (catalogContext = new CatalogContext())
            {
                return catalogContext.Movies.Find(id);
            }
        }

        public void AddMovies(Movie movie)
        {
            using (catalogContext = new CatalogContext())
            {
                catalogContext.Movies.Add(movie);
                catalogContext.SaveChanges();
            }
        }

        public void UpdateMovies(Movie movie)
        {
            using (catalogContext = new CatalogContext())
            {
                var item = catalogContext.Movies.Find(movie.Id);
                if (item != null)
                {
                    catalogContext.Entry(item).CurrentValues.SetValues(movie);
                    catalogContext.SaveChanges();
                }

            }
        }

        public void DeleteMovies(int id)
        {
            using (catalogContext = new CatalogContext())
            {
                var movie = catalogContext.Movies.Find(id);
                if (movie != null)
                {
                    catalogContext.Movies.Remove(movie);
                    catalogContext.SaveChanges();
                }
            }
        }

        //Series
        public List<Series> GetAllSeries()
        {
            using (catalogContext = new CatalogContext())
            {
                return catalogContext.Serials.ToList();
            }
        }

        public Series GetSeries(int id)
        {
            using (catalogContext = new CatalogContext())
            {
                return catalogContext.Serials.Find(id);
            }
        }

        public void AddSeries(Series series)
        {
            using (catalogContext = new CatalogContext())
            {
                catalogContext.Serials.Add(series);
                catalogContext.SaveChanges();
            }
        }

        public void UpdateSeries(Series series)
        {
            using (catalogContext = new CatalogContext())
            {
                var item = catalogContext.Serials.Find(series.Id);
                if (item != null)
                {
                    catalogContext.Entry(item).CurrentValues.SetValues(series);
                    catalogContext.SaveChanges();
                }

            }
        }

        public void DeleteSeries(int id)
        {
            using (catalogContext = new CatalogContext())
            {
                var series = catalogContext.Serials.Find(id);
                if (series != null)
                {
                    catalogContext.Serials.Remove(series);
                    catalogContext.SaveChanges();
                }
            }
        }
    }
}
