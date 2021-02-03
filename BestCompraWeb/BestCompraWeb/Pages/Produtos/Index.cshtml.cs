using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BestCompraWeb.Models;

namespace BestCompraWeb.Pages.Produtos
{
    public class IndexModel : PageModel
    {
        private readonly BestCompraWeb.Models.BestCompraWebContext _context;

        public IndexModel(BestCompraWeb.Models.BestCompraWebContext context)
        {
            _context = context;
        }

        public IList<Produto> Produto { get;set; }

        public async Task OnGetAsync()
        {
            Produto = await _context.Produto.ToListAsync();
        }
    }
}
