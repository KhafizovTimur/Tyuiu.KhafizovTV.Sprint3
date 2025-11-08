using Tyuiu.KhafizovTV.Sprint3.Task3.V16.Lib;

namespace Tyuiu.KhafizovTV.Sprint3.Task3.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();

            string str = "ice nice ice creamcc";
            char letter = 'c';

            int res = ds.GetCharCount(str, letter);
            int wait = 6;

            Assert.AreEqual(wait, res);
        }
    }
}