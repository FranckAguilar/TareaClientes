using demoasp1.Data;
using demoasp1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Namespace1
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;
        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Cliente> ListaClientes { get; set; }

        public async Task OnGet()
        {
            ListaClientes = await _context.Cliente.ToListAsync();
        }
    }
}
