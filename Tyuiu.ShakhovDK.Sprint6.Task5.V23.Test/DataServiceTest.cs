using Tyuiu.ShakhovDK.Sprint6.Task5.V23.Lib;
namespace Tyuiu.ShakhovDK.Sprint6.Task5.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\unseld\source\repos\Tyuiu.ShakhovDK.Sprint6\Tyuiu.ShakhovDK.Sprint6.Task5.V23\bin\Debug\net8.0-windows\InPutDataFileTask5V23.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool test_res = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, test_res);
        }
    }
}
