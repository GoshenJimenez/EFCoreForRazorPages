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

        public void OnGet(int? pageIndex = 1, int? pageSize = 10)
        {
            var skip = (int)((pageIndex-1) * pageSize);

            var query = _context.Roles;
            var totalRows = query.Count();

            var roles =     query
                            .Skip(skip)
                            .Take((int)pageSize)
                            .ToList();

            View.Roles = new Paged<Role>()
            {
                Items = roles,
                PageIndex = pageIndex,
                PageSize = pageSize,
                TotalRows = totalRows
            };

        }

        public class ViewModel
        {
            public Paged<Role>? Roles { get; set; }
        }
    }
}
