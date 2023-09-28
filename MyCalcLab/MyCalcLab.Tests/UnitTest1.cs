namespace MyCalcLab.Tests
{
    [TestClass]
    public class MyCalcTests
    {
        [TestMethod]
        public void Sum_10and20_30returned()
        {
            //arrange
            int x = 10;
            int y = 20;
            int expected = 30;
            //act
            MyCalc myCalc = new MyCalc();
            int actual = myCalc.Sum(x, y);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}