using demoasp1.Data;
using demoasp1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Familia> ListaFamilias { get; set; }
        public async Task OnGet()
        {
            ListaFamilias = await _context.Familia.ToListAsync();
        }
    }
}
