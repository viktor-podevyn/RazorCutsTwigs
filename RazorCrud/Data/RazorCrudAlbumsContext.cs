using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorCrud.Models;

    public class RazorCrudAlbumsContext : DbContext
    {
        public RazorCrudAlbumsContext (DbContextOptions<RazorCrudAlbumsContext> options)
            : base(options)
        {
        }

        public DbSet<Albums> Albums { get; set; }
    }
