namespace ShapeAreaCalcLib.Validators;

/// <summary>
/// Интерфейс для валидации геометрических фигур.
/// </summary>
public interface IShapeValidator
{
	/// <summary>
	/// Проверяет, является ли фигура допустимой.
	/// </summary>
	/// <returns>Возвращает true, если фигура допустима; в противном случае - false.</returns>
	public bool Validate();
}