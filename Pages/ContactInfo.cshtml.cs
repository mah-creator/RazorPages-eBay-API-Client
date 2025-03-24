using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages_API_Client.Pages
{
    public class ContactInfoModel : PageModel
    {
        public readonly string MyGithub = "https://github.com/mah-creator";
        public readonly string MyLinkedin = "https://www.linkedin.com/in/mahmoud-tahrawi";
        public readonly string MyEmail = "mah.eltahrawi@outlook.com";
        public void OnGet()
        {
        }
    }
}
