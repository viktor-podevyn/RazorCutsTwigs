using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace RazorCrud.Pages.SongsLists
{
    public class IndexModel : PageModel
    {
        private readonly RazorCrudSongsListContext _context;

        public IndexModel(RazorCrudSongsListContext context)
        {
            _context = context;
        }

        public IList<Songs> Songs { get;set; }

        public async Task OnGetAsync()
        {
            Songs = await _context.Songs.ToListAsync();
        }
    }
}
