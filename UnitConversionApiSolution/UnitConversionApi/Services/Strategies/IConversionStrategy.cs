public interface IConversionStrategy
{
    string Category { get; }
    double Convert(double value, string fromUnit, string toUnit);
}