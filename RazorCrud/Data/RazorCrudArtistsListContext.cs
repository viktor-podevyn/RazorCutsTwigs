using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorCrud.Models;

    public class RazorCrudArtistsListContext : DbContext
    {
        public RazorCrudArtistsListContext (DbContextOptions<RazorCrudArtistsListContext> options)
            : base(options)
        {
        }

        public DbSet<Artists> Artists { get; set; }
    }
