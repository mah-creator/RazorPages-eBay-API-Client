using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPages_API_Client.Model;
using static RazorPages_API_Client.Model.CategoryJsonModel;

namespace RazorPages_API_Client.Pages;

public class IndexModel : PageModel
{
        public static readonly int MAX_SUB_CATS = 3;

        private  EbayClient _ebayClient;

        private readonly List<Category> mainCategories = [
                new Category{categoryId = "58058", categoryName = "Computers/Tablets & Networking"}, 
                new Category{categoryId = "267", categoryName = "Books"}
        ];
    
        [BindProperty]
        public List<SelectListItem> MainSelectList { get; }
        public IndexModel(EbayClient ebayClient)
        {
                _ebayClient = ebayClient;
                MainSelectList = new List<SelectListItem>();
                foreach (var category in mainCategories)
                {
                        MainSelectList.Add(new SelectListItem { Text = category.categoryName, Value = category.categoryId });
                }
        }

        public JsonResult OnPost(string categoryId)
        {
                return new JsonResult(_ebayClient.GetSubcategories(categoryId, MAX_SUB_CATS));
        }
}