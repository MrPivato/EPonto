using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EPonto.Pages.RH
{
    public class ListaHoraModel : PageModel
    {

        private readonly EPonto.AppDbContext _context;

        public ListaHoraModel(EPonto.AppDbContext context)
        {
            _context = context;
        }

        public IList<Funcionario> Funcionario { get; set; }
        public IList<Ponto> Ponto { get; set; }

        public async Task OnGetAsync()
        {
            Funcionario = await _context.Funcionarios.ToListAsync();
            Ponto = await _context.Pontos.ToListAsync();
        }


    }

}