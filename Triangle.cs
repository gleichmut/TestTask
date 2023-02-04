namespace TestTask1
{
    /// <summary>
    /// Класс треугольника
    /// </summary>
    public class Triangle : Figure
    {
        /// <summary>
        /// Первая сторона треугольника
        /// </summary>
        public double A { get; set; }

        /// <summary>
        /// Вторая сторона треугольника
        /// </summary>
        public double B { get; set; }

        /// <summary>
        /// Третья сторона треугольника
        /// </summary>
        public double C { get; set; }

        /// <summary>
        /// Название фигуры
        /// </summary>
        /// <returns></returns>
        public override string GetNameFigure() => $"Triangle";

        /// <summary>
        /// Вычисление площади
        /// </summary>
        /// <returns></returns>
        public override double GetArea() => Math.Round(
                                            Math.Sqrt(
                                               _getSemiPerimeter()
                                            * (_getSemiPerimeter() - A)
                                            * (_getSemiPerimeter() - B)
                                            * (_getSemiPerimeter() - C)), 2);

        /// <summary>
        /// Вычисление полупериметра
        /// </summary>
        /// <returns></returns>
        private double _getSemiPerimeter() => (A + B + C) / 2;

        /// <summary>
        /// Вывод результата проверки на условие: является ли треугольник прямоугольным
        /// </summary>
        /// <param name="a">Первая сторона треугольника</param>
        /// <param name="b">Вторая сторона треугольника</param>
        /// <param name="c">Третья сторона треугольника</param>
        public static void PrintCheckRectangleTriangleResult(double a, double b, double c)
        {
            if (_сheckRectangleTriangle(a, b, c).Equals(true))
                Console.WriteLine("The triangle is rectangular.");
            else
                Console.WriteLine("The triangle is not rectangular.");
        }

        /// <summary>
        /// Вычисление формулы условия прямоугольного треугольника
        /// </summary>
        /// <param name="a">Первая сторона треугольника</param>
        /// <param name="b">Вторая сторона треугольника</param>
        /// <param name="c">Третья сторона треугольника</param>
        /// <returns></returns>
        private static bool _сheckRectangleTriangle(double a, double b, double c)
        {
            if (Math.Pow(_checkMaxSide(a, b, c), 2).Equals(_calculatePythagoreanTheorem(a, b, c)))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Вычисление теоремы Пифагора
        /// </summary>
        /// <param name="a">Первая сторона треугольника</param>
        /// <param name="b">Вторая сторона треугольника</param>
        /// <param name="c">Третья сторона треугольника</param>
        /// <returns></returns>
        private static double _calculatePythagoreanTheorem(double a, double b, double c)
        {
            var doubles = _checkMinSides(a, b, c);
            return Math.Pow(doubles[0], 2) + Math.Pow(doubles[1], 2);
        }

        /// <summary>
        /// Вычисление максимальной стороны треугольника
        /// </summary>
        /// <param name="a">Первая сторона треугольника</param>
        /// <param name="b">Вторая сторона треугольника</param>
        /// <param name="c">Третья сторона треугольника</param>
        /// <returns></returns>
        private static double _checkMaxSide(double a, double b, double c)
        {
            double[] doubles = { a, b, c };
            return doubles.Max();
        }

        /// <summary>
        /// Вычисление минимальных сторон треугольника
        /// Исключение максимальной стороны из списка сторон
        /// </summary>
        /// <param name="a">Первая сторона треугольника</param>
        /// <param name="b">Вторая сторона треугольника</param>
        /// <param name="c">Третья сторона треугольника</param>
        /// <returns></returns>
        private static List<double> _checkMinSides(double a, double b, double c)
        {
            double[] doubles = { a, b, c };
            var doublesList = new List<double>(doubles);

            double maxSide = _checkMaxSide(a, b, c);

            int indexMaxElement = Array.FindIndex(doubles, elem => elem.Equals(maxSide));

            doublesList.RemoveAt(indexMaxElement);
            return doublesList;
        }
    }
}