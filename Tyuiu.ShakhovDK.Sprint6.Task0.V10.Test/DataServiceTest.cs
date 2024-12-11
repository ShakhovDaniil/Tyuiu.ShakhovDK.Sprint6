using Tyuiu.ShakhovDK.Sprint6.Task0.V10.Lib;
namespace Tyuiu.ShakhovDK.Sprint6.Task0.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1;
            double wait = 11.37;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
