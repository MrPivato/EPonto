using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EPonto;

namespace EPonto.Pages
{
    public class BaterPontoModel : PageModel
    {
        private readonly EPonto.AppDbContext _context;

        public BaterPontoModel(EPonto.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Ponto Ponto { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Pontos.Add(Ponto);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}