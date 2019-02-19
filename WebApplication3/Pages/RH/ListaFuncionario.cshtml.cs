using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EPonto;

namespace EPonto.Pages.RH
{
    public class ListaFuncionarioModel : PageModel
    {
        private readonly EPonto.AppDbContext _context;

        public ListaFuncionarioModel(EPonto.AppDbContext context)
        {
            _context = context;
        }

        public IList<Funcionario> Funcionario { get;set; }

        public async Task OnGetAsync()
        {
            Funcionario = await _context.Funcionarios.ToListAsync();
        }
    }
}
