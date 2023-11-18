using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ioana_Popa_lab2.Data;
using Ioana_Popa_lab2.Models;

namespace Ioana_Popa_lab2.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Ioana_Popa_lab2.Data.Ioana_Popa_lab2Context _context;

        public CreateModel(Ioana_Popa_lab2.Data.Ioana_Popa_lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
