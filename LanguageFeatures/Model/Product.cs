namespace LanguageFeatures.Model
{
    public class Product
    {
        public string Name { get; set; } = string.Empty;
        public decimal? Price { get; set; }
        public static Product?[] GetProducts()
        {
            Product kayak = new Product
            {
                Name = "Kayak",
                Price = 1M
            };
            Product lifejacket = new Product
            {
                Name = "Lifejacket",
                Price = 1M
            };
            Product veslo = new Product
            {
                Name = "Veslo",
                Price = 1M
            };

            return new Product?[] { kayak, lifejacket, veslo, null };
        }
    }
}
