namespace ShapeAreaCalcLib.Validators;

/// <summary>
/// Класс для валидации сторон треугольника.
/// </summary>
public class TriangleShapeValidator : IShapeValidator
{
	private readonly double _side1;
	private readonly double _side2;
	private readonly double _side3;
	
	/// <summary>
	/// Конструктор класса TriangleShapeValidator.
	/// </summary>
	/// <param name="side1">Длина первой стороны треугольника.</param>
	/// <param name="side2">Длина второй стороны треугольника.</param>
	/// <param name="side3">Длина третьей стороны треугольника.</param>
	public TriangleShapeValidator(double side1, double side2, double side3)
	{
		_side1 = side1;
		_side2 = side2;
		_side3 = side3;
	}
	
	/// <summary>
	/// Проверяет, являются ли стороны треугольника допустимыми.
	/// </summary>
	/// <returns>Возвращает true, если стороны образуют допустимый треугольник; в противном случае - false.</returns>
	public bool Validate()
	{
		return _side1 > 0 && _side2 > 0 && _side3 > 0 &&
		       _side1 + _side2 > _side3 &&
		       _side1 + _side3 > _side2 &&
		       _side2 + _side3 > _side1;
	}
}