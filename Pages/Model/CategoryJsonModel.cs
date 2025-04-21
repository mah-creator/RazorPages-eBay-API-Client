namespace RazorPages_API_Client.Model;

public class CategoryJsonModel
{
    public Category category { get; set; }
    public string parentCategoryTreeNodeHref { get; set; }
    public List<ChildCategoryTreeNode> childCategoryTreeNodes { get; set; }
    public int categoryTreeNodeLevel { get; set; }

    public class Category
    {
        public string categoryId { get; set; }
        public string categoryName { get; set; }
    }

    public class ChildCategoryTreeNode
    {
        public Category category { get; set; }
        public string parentCategoryTreeNodeHref { get; set; }
        public int categoryTreeNodeLevel { get; set; }
        public bool leafCategoryTreeNode { get; set; }
        public List<ChildCategoryTreeNode> childCategoryTreeNodes { get; set; }
    }
}