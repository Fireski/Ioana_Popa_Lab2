using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ioana_Popa_lab2.Data;
using Ioana_Popa_lab2.Models;

namespace Ioana_Popa_lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Ioana_Popa_lab2.Data.Ioana_Popa_lab2Context _context;

        public IndexModel(Ioana_Popa_lab2.Data.Ioana_Popa_lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book
            .Include(b => b.Publisher)
            .ToListAsync();
        }
    }
    }

