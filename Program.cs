/*
    Задание:
    Напишите на C# библиотеку для поставки внешним клиентам, которая умеет:
     - вычислять площадь круга по радиусу;                                             формула: S = π × r^2
     - вычислять площадь треугольника по трем сторонам.                                формула: квадрат большей стороны треугольника равен сумме квадратов двух меньших сторон

    Юнит - тесты
    Легкость добавления других фигур
    Вычисление площади фигуры без знания типа фигуры в compile-time
    Проверку на то, является ли треугольник прямоугольным
*/

using TestTask1;

public class Program
{
    private static void Main(string[] args)
    {
        //Вводим радиус
        Console.Write("Enter a raduis of Circle: ");

        //Реализована проверка на неотрицательность
        double radius = Check.CheckNegativeNumeric(Convert.ToDouble(Console.ReadLine()));

        //Вызывается класс Circle, передается радиус
        var circle = new Circle { Radius = radius };
        PrintFigure(circle);

        //Вводим первую сторону треугольника
        Console.Write("Enter a A sige of Triangle: ");
        double a = Check.CheckNegativeNumeric(Convert.ToDouble(Console.ReadLine()));

        //Вводим вторую сторону треугольника
        Console.Write("Enter a B sige of Triangle: ");
        double b = Check.CheckNegativeNumeric(Convert.ToDouble(Console.ReadLine()));

        //Вводим третью сторону треугольника
        Console.Write("Enter a C sige of Triangle: ");
        double c = Check.CheckNegativeNumeric(Convert.ToDouble(Console.ReadLine()));

        //Вызывается класс Triangle, передаются стороны треугольника
        var triangle = new Triangle { A = a, B = b, C = c };
        PrintFigure(triangle);

        //Вывод площади фигуры

        //3.5, 2.1, 2.8 - значения для прямоугольного треугольника
        //Проверка является ли треугольник прямоугольным
        Triangle.PrintCheckRectangleTriangleResult(a, b, c);
    }
    public static void PrintFigure(Figure figure) => Console.WriteLine($"Area of {figure.GetNameFigure()} equals {figure.GetArea()}");
}