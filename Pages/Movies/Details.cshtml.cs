using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RaozrPagesMovie.Data;
using RaozrPagesMovie.Models;

namespace RaozrPagesMovie.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly RaozrPagesMovie.Data.RaozrPagesMovieContext _context;

        public DetailsModel(RaozrPagesMovie.Data.RaozrPagesMovieContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FirstOrDefaultAsync(m => m.id == id);
            if (movie == null)
            {
                return NotFound();
            }
            else
            {
                Movie = movie;
            }
            return Page();
        }
    }
}
