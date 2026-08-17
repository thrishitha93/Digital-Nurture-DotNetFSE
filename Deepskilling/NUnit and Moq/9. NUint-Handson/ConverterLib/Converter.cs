namespace ConverterLib
{
    public class Converter : IConverter
    {
        private readonly IDollarToEuroExchangeRateFeed _exchangeRateFeed;

        public Converter(IDollarToEuroExchangeRateFeed exchangeRateFeed)
        {
            _exchangeRateFeed = exchangeRateFeed;
        }

        public double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        public double KilogramToPound(double kilogram)
        {
            return kilogram * 2.20462;
        }

        public double KilometerToMile(double kilometer)
        {
            return kilometer * 0.621371;
        }

        public double LiterToGallon(double liter)
        {
            return liter * 0.264172;
        }

        public double USDToEuro(double dollar)
        {
            double rate = _exchangeRateFeed.GetExchangeRate();
            return dollar * rate;
        }
    }
}