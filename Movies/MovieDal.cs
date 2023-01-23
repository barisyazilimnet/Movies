using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies
{
    public class MovieDal
    {
        public List<Movie> GetAll()
        {
            using (DbMoviesContext context = new DbMoviesContext())
            {
                return context.Movies.Where(p => p.IsDeleted == false).ToList();
            }
        }
        public List<Movie> IsName(string key)
        {
            using (DbMoviesContext context = new DbMoviesContext())
            {
                return context.Movies.Where(p => p.Name == key && p.IsDeleted == false).ToList();
            }
        }
        public void Add(Movie movie)
        {
            using (DbMoviesContext context = new DbMoviesContext())
            {
                //context.Products.Add(product);
                var entity = context.Entry(movie);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Update(Movie movie)
        {
            using (DbMoviesContext context = new DbMoviesContext())
            {
                var entity = context.Entry(movie);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
