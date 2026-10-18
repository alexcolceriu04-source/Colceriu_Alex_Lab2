using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Colceriu_Alex_Lab2.Models;

namespace Colceriu_Alex_Lab2.Data
{
    public class Colceriu_Alex_Lab2Context : DbContext
    {
        public Colceriu_Alex_Lab2Context (DbContextOptions<Colceriu_Alex_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Colceriu_Alex_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Colceriu_Alex_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Colceriu_Alex_Lab2.Models.Author> Author { get; set; } = default!;
    }
}