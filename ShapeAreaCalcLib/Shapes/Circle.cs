using ShapeAreaCalcLib.Shapes;
using ShapeAreaCalcLib.Validators;

namespace ShapeAreaCalcLib;

/// <summary>
/// Класс, представляющий круг и позволяющий вычислить его площадь.
/// </summary>
public class Circle : IShape
{
	private double _radius;
	
	public double Radius => _radius;
	
	/// <summary>
	/// Конструктор класса Circle.
	/// </summary>
	/// <param name="radius">Радиус круга. Должен быть положительным числом.</param>
	/// <exception cref="ArgumentException">Выбрасывается, если радиус не является допустимым значением.</exception>
	public Circle(double radius)
	{
		CircleShapeValidator validator = new(radius);
		if (!validator.Validate())
		{
			throw new ArgumentException("Invalid radius value");
		}
		_radius = radius;
	}

	/// <summary>
	/// Вычисляет площадь круга.
	/// </summary>
	/// <returns>Возвращает площадь круга.</returns>
	public double CalculateArea()
	{
		CircleShapeValidator validator = new(Radius);
		if (!validator.Validate())
		{
			throw new ArgumentException("Invalid radius value");
		}
		return (Math.PI * Math.Pow(_radius, 2));
	}
}