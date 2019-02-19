using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EPonto.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _db;

        public IndexModel(AppDbContext db) { _db = db; }

        public IList<Funcionario> Funcionarios { get; private set; }

        [TempData]
        public string Message { get; set; }

        public async Task OnGetAsync()
        {
            Funcionarios = await _db.Funcionarios.AsNoTracking().ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int Id)
        {
            var customer = await _db.Funcionarios.FindAsync(Id);

            if (customer != null)
            {
                _db.Funcionarios.Remove(customer);
                await _db.SaveChangesAsync();
            }

            return RedirectToPage();
        }

    }
}
