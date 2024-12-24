using Tyuiu.ShakhovDK.Sprint6.Task4.V11.Lib;
namespace Tyuiu.ShakhovDK.Sprint6.Task4.V11.Test
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
            double[] waitArray = { 20.36, 15.42, 10.99, 7.43, 4.33, 1, 0, -8.87, -13.03, -16.53, -19.6 };
            double[] resArray = ds.GetMassFunction(startValue, endValue);
            CollectionAssert.AreEqual(waitArray, resArray);
        }
    }
}
