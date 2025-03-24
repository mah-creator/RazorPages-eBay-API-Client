using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages_API_Client.Pages
{
    
    public class QueryApiModel : PageModel
    {
        public List<string> SubCategories = new List<string>();
        public void OnGet()
        {
        }
    }
}
