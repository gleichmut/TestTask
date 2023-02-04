using TestTask1;

namespace TestTask1NUnitTests
{
    public class TestTask1Tests
    {
        /// <summary>
        /// Тест площадь круга
        /// </summary>
        [Test]
        public void TestRadius5_V78_54ReturnedTrue()
        {
            double radius = 5;
            double expected = 78.54;

            var circle = new Circle { Radius = radius };
            double actual = Math.Round(circle.GetArea(), 2);

            Assert.That(actual, Is.EqualTo(expected));
        }

        /// <summary>
        /// Тест площади треугольника
        /// </summary>
        [Test]
        public void TestTriangle3_8_10_V9_92ReturnedTrue()
        {
            double a = 3;
            double b = 8;
            double c = 10;
            double expected = 9.92;

            var triangle = new Triangle { A = a, B = b, C = c };
            double actual = Math.Round(triangle.GetArea(), 2);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}