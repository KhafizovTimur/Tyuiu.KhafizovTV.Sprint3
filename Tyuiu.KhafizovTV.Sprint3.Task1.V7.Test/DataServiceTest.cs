using Tyuiu.KhafizovTV.Sprint3.Task1.V7.Lib;


namespace Tyuiu.KhafizovTV.Sprint3.Task1.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 9;
            double value = 0.25;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 0.021;

            Assert.AreEqual(wait, res);
        }
    }
}
