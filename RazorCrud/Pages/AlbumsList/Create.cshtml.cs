using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RazorCrud.Pages.AlbumsList
{
    public class CreateModel : PageModel
    {
        private readonly RazorCrudAlbumsContext _context;

        public CreateModel(RazorCrudAlbumsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Albums Albums { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Albums.Add(Albums);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
