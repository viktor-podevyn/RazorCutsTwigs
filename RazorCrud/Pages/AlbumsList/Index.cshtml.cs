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
    public class IndexModel : PageModel
    {
        private readonly RazorCrudAlbumsContext _context;

        public IndexModel(RazorCrudAlbumsContext context)
        {
            _context = context;
        }

        public IList<Albums> Albums { get;set; }

        public async Task OnGetAsync()
        {
            Albums = await _context.Albums.ToListAsync();
        }
    }
}
