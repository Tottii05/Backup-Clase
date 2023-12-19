using Testing;
namespace Testing_Pruebas
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange //
            float Base = 7, Exponent = 6, Expected = 117649, Total;

            // Act //
            Total = Validate.Power(Base, Exponent);

            // Assert //
            Assert.AreEqual(Total , Expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            // Arrange //
            float Base = 2, Exponent = -3, Expected = 0.125f, Total;

            // Act //
            Total = Validate.Power(Base, Exponent);

            // Assert //
            Assert.AreEqual(Total, Expected);
        }
    }
}