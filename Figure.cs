namespace TestTask1
{
    /// <summary>
    /// Абстрактный класс фигур
    /// </summary>
    abstract class Figure
    {
        /// <summary>
        /// Вычисление площадь
        /// </summary>
        /// <returns></returns>
        public abstract double GetArea();

        /// <summary>
        /// Название фигуры
        /// </summary>
        /// <returns></returns>
        public abstract string GetNameFigure();
   
    }
}