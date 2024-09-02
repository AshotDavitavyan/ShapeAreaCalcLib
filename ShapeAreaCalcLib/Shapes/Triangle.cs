using ShapeAreaCalcLib.Shapes;
using ShapeAreaCalcLib.Validators;

namespace ShapeAreaCalcLib;

/// <summary>
/// Класс, представляющий треугольник и позволяющий вычислить его площадь и проверить, является ли он прямоугольным.
/// </summary>
public class Triangle : IShape
{
	private double _side1;
	private double _side2;
	private double _side3;

	public double Side1 => _side1;
	public double Side2 => _side2;
	public double Side3 => _side3;
	
	/// <summary>
	/// Конструктор класса Triangle.
	/// </summary>
	/// <param name="side1">Длина первой стороны треугольника.</param>
	/// <param name="side2">Длина второй стороны треугольника.</param>
	/// <param name="side3">Длина третьей стороны треугольника.</param>
	/// <exception cref="ArgumentException">Выбрасывается, если стороны не образуют допустимый треугольник.</exception>
	public Triangle(double side1, double side2, double side3)
	{
		TriangleShapeValidator validator = new(side1, side2, side3);
		if (!validator.Validate())
		{
			throw new ArgumentException("Invalid triangle sides");
		}
		_side1 = side1;
		_side2 = side2;
		_side3 = side3;
	}
	
	/// <summary>
	/// Вычисляет площадь треугольника с использованием формулы Герона.
	/// </summary>
	/// <returns>Возвращает площадь треугольника.</returns>
	public double CalculateArea()
	{	
		TriangleShapeValidator validator = new(Side1, Side2, Side3);
		if (!validator.Validate())
		{
			throw new ArgumentException("Invalid triangle sides");
		}
		double s = (_side1 + _side2 + _side3) / 2;
		return Math.Sqrt(s * (s - _side1) * (s - _side2) * (s - _side3));
	}
}