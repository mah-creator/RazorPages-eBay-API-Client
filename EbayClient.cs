using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using eBay.ApiClient.Auth.OAuth2;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RazorPages_API_Client.Model;
using static RazorPages_API_Client.Model.CategoryJsonModel;

public class EbayClient
{
    private readonly HttpClient _httpClient;
    public EbayClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public List<Category> GetSubcategories(string parentId, int limit)
    {
        string jsonString =
            _httpClient.GetAsync($"https://api.ebay.com/commerce/taxonomy/v1/category_tree/15/get_category_subtree?category_id={parentId}&limit={limit}")
            .Result.Content.ReadAsStringAsync().Result;

        CategoryJsonModel? categoryJsonModel = JsonConvert.DeserializeObject<CategoryJsonModel>(jsonString);

        
        // TODO
        List<Category> subcategories = new List<Category>();
        foreach (var childCategoryTreeNode in categoryJsonModel.childCategoryTreeNodes)
        {
            subcategories.Add(childCategoryTreeNode.category);
        }
        return subcategories;
    }

    public void GetCategorySubtree(string categoryID, int limit)
    {
        // TODO
        _httpClient.GetAsync($"https://api.ebay.com/commerce/taxonomy/v1/category_tree/15/get_category_subtree?category_id={categoryID}&limit={limit}");
    }

    public async Task SearchByCategory(string categoryID)
    {
        // TODO
        HttpResponseMessage response = await _httpClient.GetAsync($"https://api.ebay.com/buy/browse/v1/item_summary/search?category_ids={categoryID}&limit=3");
        string jsonString = await response.Content.ReadAsStringAsync();
    }
}