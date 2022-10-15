using EFCoreForRazorPages.Infrastructure.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EFCoreForRazorPages.Infrastructure.Domain.Models;

namespace EFCoreForRazorPages.Pages.Manage.Roles
{
    public class Index : PageModel
    {
        private ILogger<Index> _logger;
        private DefaultDbContext _context;

        [BindProperty]
        public ViewModel View { get; set; }

        public Index(DefaultDbContext context, ILogger<Index> logger)
        {
            _logger = logger;
            _context = context;
            View = View ?? new ViewModel();
        }

        public void OnGet()
        {
            View.Roles = _context.Roles.ToList();
        }

        public class ViewModel
        {
            public List<Role>? Roles { get; set; }
        }
    }
}
