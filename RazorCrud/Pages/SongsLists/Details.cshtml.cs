using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace RazorCrud.Pages.SongsLists
{
    public class DetailsModel : PageModel
    {
        private readonly RazorCrudSongsListContext _context;

        public DetailsModel(RazorCrudSongsListContext context)
        {
            _context = context;
        }

        public Songs Songs { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Songs = await _context.Songs.FirstOrDefaultAsync(m => m.ID == id);

            if (Songs == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
