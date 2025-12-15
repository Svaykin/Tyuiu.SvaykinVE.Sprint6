using Tyuiu.SvaykinVE.Sprint6.Task6.V11.Lib;
namespace Tyuiu.SvaykinVE.Sprint6.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\svayk\Downloads\InPutDataFileTask6V11.txt";
            FileInfo file = new FileInfo(path);
            Assert.AreEqual(true, file.Exists);
        }
    }
}
