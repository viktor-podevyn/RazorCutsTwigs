using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace RazorCrud.Pages.AlbumsList
{
    public class DeleteModel : PageModel
    {
        private readonly RazorCrudAlbumsContext _context;

        public DeleteModel(RazorCrudAlbumsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Albums Albums { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Albums = await _context.Albums.FirstOrDefaultAsync(m => m.ID == id);

            if (Albums == null)
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

            Albums = await _context.Albums.FindAsync(id);

            if (Albums != null)
            {
                _context.Albums.Remove(Albums);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
