using System.Collections;

namespace LanguageFeatures.Model
{
    public class ShoppingCart : IProductSelection
    {
        private List<Product> products = new();
        public ShoppingCart(params Product[] prods)
        {
            products.AddRange(prods);
        }
        public IEnumerable<Product>? Products { get => products; }
    }
}
