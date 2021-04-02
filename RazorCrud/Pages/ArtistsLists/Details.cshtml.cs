using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCrud.Models;

namespace RazorCrud.Pages.ArtistsLists
{
    public class DetailsModel : PageModel
    {
        private readonly RazorCrudArtistsListContext _context;

        public DetailsModel(RazorCrudArtistsListContext context)
        {
            _context = context;
        }

        public Artists Artists { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Artists = await _context.Artists.FirstOrDefaultAsync(m => m.ID == id);

            if (Artists == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
