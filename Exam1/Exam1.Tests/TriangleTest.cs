namespace Exam1.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    /// <summary>
    /// Тесты для класса Triangle.
    /// </summary>
    [TestClass]
    public class TriangleTest
    {
        /// <summary>
        /// Тест проверяет правильность вычисления полупериметра.
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
            Assert.AreEqual(-1, Triangle.S(20, 4, 3));
        }

        /// <summary>
        /// Тест проверят правильность выполнения оператора "++";
        /// </summary>
        [TestMethod]
        public void IncrementTest()
        {
            Triangle t = new Triangle(3, 4, 5);
            Assert.AreEqual(new Triangle(4, 5, 6), ++t);
        }

        /// <summary>
        /// Тест проверяет правильность выполнения оператора "--".
        /// </summary>
        [TestMethod]
        public void DecrementTest()
        {
            Triangle t = new Triangle(3, 4, 5);
            Assert.AreEqual(new Triangle(2, 3, 4), --t);
        }

        /// <summary>
        /// Тест проверяет правильность преобазования Triangle к типу double (неявное преобразование).
        /// </summary>
        [TestMethod]
        public void ConvertToDoubleTest()
        {
            double t = new Triangle(20, 2, 3);
            double t1 = new Triangle(3, 4, 5);

            Assert.AreEqual(-1, t);
            Assert.AreEqual(6, t1);
        }

        /// <summary>
        /// Тест проверяет правильность преобразования Triangle к типу bool (явное преобразование);
        /// </summary>
        [TestMethod]
        public void ConvertToBoolTest()
        {
            bool exists1 = (bool)new Triangle(20, 2, 3);
            bool exists2 = (bool)new Triangle(3, 4, 5);

            Assert.AreEqual(false, exists1);
            Assert.AreEqual(true, exists2);
        }

        /// <summary>
        /// Тест провверяет правильность выполнения оператора "==".
        /// </summary>
        [TestMethod]
        public void EqualTest()
        {
            Triangle a = new Triangle(3, 4, 5);
            Triangle b = new Triangle(5, 4, 3);
            Triangle c = new Triangle(3, 4, 5);

            Assert.AreEqual(true, a == c);
            Assert.AreEqual(false, a == b);
        }

        /// <summary>
        /// Тест проверяет правильность выполнения операции сравнения больше или равно.
        /// </summary>
        [TestMethod]
        public void GraterOrEqualTest()
        {
            Triangle a = new Triangle(3, 4, 5);
            Triangle b = new Triangle(5, 12, 13);
            Triangle c = new Triangle(3, 4, 5);

            Assert.AreEqual(true, b >= a);
            Assert.AreEqual(true, a >= c);
            Assert.AreEqual(false, a >= b);
        }

        /// <summary>
        /// Тест проверяет правильность выполнения операции сравнения меньше или равно.
        /// </summary>
        [TestMethod]
        public void LessOrEqualTest()
        {
            Triangle a = new Triangle(3, 4, 5);
            Triangle b = new Triangle(5, 12, 13);
            Triangle c = new Triangle(3, 4, 5);

            Assert.AreEqual(true, a <= b);
            Assert.AreEqual(true, a <= c);
            Assert.AreEqual(false, b <= a);
        }
    }
}
