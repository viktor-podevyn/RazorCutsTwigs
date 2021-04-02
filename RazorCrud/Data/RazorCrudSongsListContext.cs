using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorCrud.Models;

    public class RazorCrudSongsListContext : DbContext
    {
        public RazorCrudSongsListContext (DbContextOptions<RazorCrudSongsListContext> options)
            : base(options)
        {
        }

        public DbSet<Songs> Songs { get; set; }
    }
