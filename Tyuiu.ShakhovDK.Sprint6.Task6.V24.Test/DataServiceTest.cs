using Tyuiu.ShakhovDK.Sprint6.Task6.V24.Lib;
namespace Tyuiu.ShakhovDK.Sprint6.Task6.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\unseld\Desktop\InPutDataFileTask6V24.txt";
            string wait = "EovFJ Vud RgdW KwQBrOM Ewyq";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}
