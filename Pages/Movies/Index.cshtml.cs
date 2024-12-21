using Microsoft.AspNetCore.Mvc.RazorPages;
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

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
