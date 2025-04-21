using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages_API_Client.Pages;

public class CategoryChoiceModel : PageModel
{
    private  EbayClient _ebayClient;
    public CategoryChoiceModel(EbayClient ebayClient)
    {
            _ebayClient = ebayClient;
    }
    public JsonResult OnGet(string categoryId)
    {
        return new JsonResult(_ebayClient.GetSubcategories(categoryId, IndexModel.MAX_SUB_CATS));
    }
}

