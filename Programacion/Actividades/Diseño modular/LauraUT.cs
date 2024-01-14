using Exercicis;
namespace PruebasUT
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OkName()
        {
            bool expected = true;
            string name = "Juan";

            bool result = Ex31.CharacNameValidation(name);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WrongName()
        {
            bool expected = false;
            string name = "Juaaaaaaaan";

            bool result = Ex31.CharacNameValidation(name);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void OkNum()
        {
            bool expected = true;
            int num = 35;

            bool result = Ex31.RangNum(num);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WrongNum()
        {
            bool expected = false;
            int num = 502;

            bool result = Ex31.RangNum(num);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void OkRandom()
        {
            int result = Ex31.MapPosition();

            Assert.IsTrue(result > 1 && result <500);
            /*El límite del random tiene que ser 100 no 500*/
        }
    }
}