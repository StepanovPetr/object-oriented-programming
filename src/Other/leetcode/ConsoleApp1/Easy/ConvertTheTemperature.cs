namespace LeetCode.Easy
{
    public class ConvertTheTemperature
    {
        public double[] ConvertTemperature(double celsius)
        {
            return new double[] { celsius + 273.15, celsius * 1.80 + 32.00 };
        }
    }
}