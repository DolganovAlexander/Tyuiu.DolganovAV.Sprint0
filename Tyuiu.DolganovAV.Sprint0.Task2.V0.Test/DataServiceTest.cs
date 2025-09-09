using Tyuiu.DolganovAV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.DolganovAV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Александр";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Александр", res);
        }
    }
}