public class ConversionService : IConversionService
{
    private readonly IEnumerable<IConversionStrategy> _strategies;
    public ConversionService(IEnumerable<IConversionStrategy> strategies)
    {
        _strategies = strategies;
    }
    public double Convert(
        string category,
        double value,
        string fromUnit,
        string toUnit)
    {
        var strategy = _strategies.FirstOrDefault(
            s => s.Category.Equals(
                category,
                StringComparison.OrdinalIgnoreCase));
        if (strategy == null)
            throw new ArgumentException($"Category '{category}' not supported.");
        return strategy.Convert(value, fromUnit, toUnit);
    }
}