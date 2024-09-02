namespace ShapeAreaCalcLib.Validators;

/// <summary>
/// Класс для валидации радиуса круга.
/// </summary>
public class CircleShapeValidator : IShapeValidator
{
	private readonly double _radius;

	/// <summary>
	/// Конструктор класса CircleShapeValidator.
	/// </summary>
	/// <param name="radius">Радиус круга. Должен быть положительным числом.</param>
	public CircleShapeValidator(double radius)
	{
		_radius = radius;
	}
	
	/// <summary>
	/// Проверяет, является ли радиус круга допустимым.
	/// </summary>
	/// <returns>Возвращает true, если радиус положительный; в противном случае - false.</returns>
	public bool Validate()
	{
		return _radius > 0;
	}
}