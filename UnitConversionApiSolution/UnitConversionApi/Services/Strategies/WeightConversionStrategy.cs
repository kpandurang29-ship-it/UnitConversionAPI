public class WeightConversionStrategy : IConversionStrategy
{
    public string Category => "weight";
    private readonly Dictionary<string, double> _factors = new()
    {
        { "kilogram", 1.0 },
        { "gram", 1000.0 },
        { "pound", 2.20462 }
    };
    public double Convert(double value, string fromUnit, string toUnit)
    {
        var kg = value / _factors[fromUnit.ToLower()];
        return kg * _factors[toUnit.ToLower()];
    }
}