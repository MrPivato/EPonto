using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EPonto;

namespace EPonto.Pages.RH
{
    public class CriaFuncionarioModel : PageModel
    {
        private readonly EPonto.AppDbContext _context;

        public CriaFuncionarioModel(EPonto.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Funcionario Funcionario { get; set; }

        [TempData]
        public string Message { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Funcionarios.Add(Funcionario);
            await _context.SaveChangesAsync();
            var msg = $"Funcionário {Funcionario.Nome} Foi adicionado com sucesso!";
            Message = msg;
            return RedirectToPage("./CriaFuncionario");
        }
    }
}