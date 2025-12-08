using Tyuiu.SvaykinVE.Sprint6.Task0.V18.Lib;
namespace Tyuiu.SvaykinVE.Sprint6.Task0.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(1.056, ds.Calculate(3));
        }
    }
}
