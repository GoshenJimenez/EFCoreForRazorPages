using System.Diagnostics.Contracts;

namespace EFCoreForRazorPages.Infrastructure.Domain.Models
{
    public class Role
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Abbreviation { get; set; }
    }
}
