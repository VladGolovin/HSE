namespace Exam1.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TriangleTest
    {
        /// <summary>
        /// Тест проверяет правильность вычисления периметра.
        /// </summary>
        [TestMethod]
        public void PTest()
        {
            double p = Triangle.P(2, 2, 2);

            Assert.AreEqual(3, p);
        }

        /// <summary>
        /// Тест проверяет правильность вычисления площади (метода класса).
        /// </summary>
        [TestMethod]
        public void STest()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            Assert.AreEqual(6, triangle.S());
        }

        /// <summary>
        /// Тест проверяет правильность вычисления площади (статической функции).
        /// </summary>
        [TestMethod]
        public void SStaticTest()
        {
            Assert.AreEqual(6, Triangle.S(3, 4, 5));
        }
    }
}
