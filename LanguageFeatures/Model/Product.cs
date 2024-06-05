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
                Price = 125M
            };
            Product lifejacket = new Product
            {
                Name = "Lifejacket",
                Price = 244M
            };

            return new Product?[] { kayak, lifejacket,null };
        }
    }
}
