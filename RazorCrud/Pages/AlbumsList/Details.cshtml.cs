using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCrud.Models;

namespace RazorCrud.Pages.AlbumsList
{
    public class DetailsModel : PageModel
    {
        private readonly RazorCrudAlbumsContext _context;

        public DetailsModel(RazorCrudAlbumsContext context)
        {
            _context = context;
        }

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
    }
}
