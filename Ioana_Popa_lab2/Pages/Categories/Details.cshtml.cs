using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ioana_Popa_lab2.Data;
using Ioana_Popa_lab2.Models;

namespace Ioana_Popa_lab2.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Ioana_Popa_lab2.Data.Ioana_Popa_lab2Context _context;

        public DetailsModel(Ioana_Popa_lab2.Data.Ioana_Popa_lab2Context context)
        {
            _context = context;
        }

        public BookCategory BookCategory { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookcategory = await _context.BookCategory.FirstOrDefaultAsync(m => m.ID == id);
            if (bookcategory == null)
            {
                return NotFound();
            }
            else
            {
                BookCategory = bookcategory;
            }
            return Page();
        }
    }
}
