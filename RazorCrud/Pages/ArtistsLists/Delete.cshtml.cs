using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace RazorCrud.Pages.ArtistsLists
{
    public class DeleteModel : PageModel
    {
        private readonly RazorCrudArtistsListContext _context;

        public DeleteModel(RazorCrudArtistsListContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Artists = await _context.Artists.FindAsync(id);

            if (Artists != null)
            {
                _context.Artists.Remove(Artists);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
