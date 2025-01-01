using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RaozrPagesMovie.Models;

namespace RaozrPagesMovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RaozrPagesMovie.Data.RaozrPagesMovieContext _context;

        public IndexModel(RaozrPagesMovie.Data.RaozrPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Genres { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? MovieGenre { get; set; } 

        public async Task OnGetAsync()
        {
            var movies = from m in _context.Movie
                        select m;
            if(!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));
            }
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
