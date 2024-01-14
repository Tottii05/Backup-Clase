using MyNameSpace;
namespace PruebasUT
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OkName()
        {
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            MyClass.NameChecker("Juan");

            string expected = "Personaje creado correctamente";

            Assert.AreEqual(expected, sw.ToString().Trim());
        }
    }
}