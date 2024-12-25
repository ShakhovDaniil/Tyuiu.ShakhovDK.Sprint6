using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShakhovDK.Sprint6.Task5.V23.Lib
{
    public class DataService : ISprint6Task5V23
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            len = File.ReadAllLines(path).Length;
            double[] numsArray = new double[len];
            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[index] = Math.Round(Convert.ToDouble(line), 3);
                    index++;
                }
            }
            numsArray = numsArray.Where(x => x < 0).ToArray();
            return numsArray;
        }
    }
}
