using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShakhovDK.Sprint6.Task4.V11.Lib
{
    public class DataService : ISprint6Task4V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] resArray;
            int len = (stopValue - startValue) + 1;
            resArray = new double[len];
            double function;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if ((2 - 2 * x) == 0)
                {
                    resArray[count] = 0;
                    count++;
                    continue;
                }
                function = Math.Round(Math.Cos(x) + (Math.Sin(x) / (2 - 2 * x)) - 4 * x, 2);
                resArray[count] = function;
                count++;
            }

            return resArray;
        }
    }
}
