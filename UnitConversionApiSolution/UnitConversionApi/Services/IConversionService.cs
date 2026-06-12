public interface IConversionService
{
    double Convert(string category,
                   double value,
                   string fromUnit,
                   string toUnit);
}