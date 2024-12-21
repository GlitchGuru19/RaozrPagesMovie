using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RaozrPagesMovie.Models;

namespace RaozrPagesMovie.Data
{
    public class RaozrPagesMovieContext : DbContext
    {
        public RaozrPagesMovieContext (DbContextOptions<RaozrPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RaozrPagesMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
