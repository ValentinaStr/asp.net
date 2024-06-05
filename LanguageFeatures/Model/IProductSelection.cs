namespace LanguageFeatures.Model
{
    public class IProductSelection
    {
       public IEnumerable<Product>? Products { get; }
       public IEnumerable<string>? Names => Products?.Select(p => p.Name);
    }
}
