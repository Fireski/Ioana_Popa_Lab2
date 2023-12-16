using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ioana_Popa_lab2.Models;

namespace Ioana_Popa_lab2.Data
{
    public class Ioana_Popa_lab2Context : DbContext
    {
        public Ioana_Popa_lab2Context (DbContextOptions<Ioana_Popa_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Ioana_Popa_lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Ioana_Popa_lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Ioana_Popa_lab2.Models.BookCategory> BookCategory { get; set; } = default!;
    }
}
