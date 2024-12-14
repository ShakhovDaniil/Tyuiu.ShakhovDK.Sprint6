using Tyuiu.ShakhovDK.Sprint6.Task2.V25.Lib;
namespace Tyuiu.ShakhovDK.Sprint6.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int endValue = 5;
            double[] testArray = ds.GetMassFunction(startValue, endValue);
            double[] wait = { 23.61, 16.08, 7.84, 4.58, 2.88, 0.75, -4.47, -9.46, -7.41, -6.16, -7.29 };
            CollectionAssert.AreEqual(wait, testArray);

        }
    }
}
