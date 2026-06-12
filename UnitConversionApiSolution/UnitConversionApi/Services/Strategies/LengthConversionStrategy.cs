public class LengthConversionStrategy : IConversionStrategy
{
    public string Category => "length";
    private readonly Dictionary<string, double> _factors = new()
    {
        { "meter", 1.0 },
        { "foot", 3.28084 },
        { "kilometer", 0.001 }
    };
    public double Convert(double value, string fromUnit, string toUnit)
    {
        var meters = value / _factors[fromUnit.ToLower()];
        return meters * _factors[toUnit.ToLower()];
    }
}