namespace ShapeAreaCalcLib.Extensions;

/// <summary>
/// Класс с методами расширения для работы с треугольниками.
/// </summary>
public static class TriangleExtensions
{
	/// <summary>
	/// Метод расширения для проверки, является ли треугольник прямоугольным.
	/// </summary>
	/// <param name="triangle">Экземпляр треугольника.</param>
	/// <returns>Возвращает true, если треугольник прямоугольный; в противном случае - false.</returns>
	public static bool IsRightAngled(this Triangle triangle)
	{
		double[] sides = { triangle.Side1, triangle.Side2, triangle.Side3 };
		Array.Sort(sides);
		return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
	}
}