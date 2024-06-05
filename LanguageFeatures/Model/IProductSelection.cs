namespace LanguageFeatures.Model
{
    public interface IProductSelection
    {
        public IEnumerable<Product>? Products { get; }
        public IEnumerable<string>? Names => Products?.Select(p => p.Name);
    }
}
