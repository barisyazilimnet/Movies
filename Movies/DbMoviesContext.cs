using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    public class DbMoviesContext:DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}
