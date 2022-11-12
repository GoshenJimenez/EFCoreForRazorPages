using Microsoft.AspNetCore.Mvc;

namespace EFCoreForRazorPages
{
    public class LookupsController : Controller
    {

        [HttpGet]
        public string? Hello()
        {
            return "Hello";
        }
    }
}
