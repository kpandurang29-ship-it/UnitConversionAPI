public class TemperatureConversionStrategy : IConversionStrategy
{
    public string Category => "temperature";
    public double Convert(double value, string fromUnit, string toUnit)
    {
        fromUnit = fromUnit.ToLower();
        toUnit = toUnit.ToLower();
        if (fromUnit == toUnit)
            return value;
        return (fromUnit, toUnit) switch
        {
            ("celsius", "fahrenheit") => (value * 9 / 5) + 32,
            ("fahrenheit", "celsius") => (value - 32) * 5 / 9,
            ("celsius", "kelvin") => value + 273.15,
            ("kelvin", "celsius") => value - 273.15,
            _ => throw new ArgumentException("Unsupported conversion")
        };
    }
}