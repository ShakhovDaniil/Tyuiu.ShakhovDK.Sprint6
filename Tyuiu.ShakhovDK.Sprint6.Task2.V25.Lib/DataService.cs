using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShakhovDK.Sprint6.Task2.V25.Lib
{
    public class DataService : ISprint6Task2V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double function;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                function = Math.Round(((5 * x + 2.5) / (Math.Sin(x) - 2)) + 2, 2);
                valueArray[count] = function;
                count++;
            }
            return valueArray;
        }
    }
}
