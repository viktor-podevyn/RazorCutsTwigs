using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace RazorCrud.Pages.ArtistsLists
{
    public class IndexModel : PageModel
    {
        private readonly RazorCrudArtistsListContext _context;

        public IndexModel(RazorCrudArtistsListContext context)
        {
            _context = context;
        }

        public IList<Artists> Artists { get;set; }

        public async Task OnGetAsync()
        {
            Artists = await _context.Artists.ToListAsync();
        }
    }
}
