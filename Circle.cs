namespace TestTask1
{
    /// <summary>
    /// Класс круга
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Вычисление площади круга
        /// </summary>
        /// <returns></returns>
        public override double GetArea() => Math.Round(
                                            Math.PI * Math.Pow(Radius, 2), 2);

        /// <summary>
        /// Название фигуры
        /// </summary>
        /// <returns></returns>
        public override string GetNameFigure() => $"Circle";
    }
}