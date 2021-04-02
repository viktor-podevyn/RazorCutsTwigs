using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RazorCrud.Pages.ArtistsLists
{
    public class CreateModel : PageModel
    {
        private readonly RazorCrudArtistsListContext _context;

        public CreateModel(RazorCrudArtistsListContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Artists Artists { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Artists.Add(Artists);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
