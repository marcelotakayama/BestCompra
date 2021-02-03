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
    public class DetailsModel : PageModel
    {
        private readonly BestCompraWeb.Models.BestCompraWebContext _context;

        public DetailsModel(BestCompraWeb.Models.BestCompraWebContext context)
        {
            _context = context;
        }

        public Produto Produto { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Produto = await _context.Produto.FirstOrDefaultAsync(m => m.ID == id);

            if (Produto == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
