using demoasp1.Data;
using demoasp1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace1
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _context;
        public CreateModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cliente Cli { get; set; }
        public IActionResult OnPost()
        {
            _context.Cliente.Add(Cli);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
