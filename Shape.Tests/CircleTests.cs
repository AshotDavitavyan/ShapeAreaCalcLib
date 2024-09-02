using ShapeAreaCalcLib;

namespace Tests;

/// <summary>
/// Класс, содержащий тесты для проверки функциональности класса Circle.
/// </summary>
public class CircleTests
{
	/// <summary>
	/// Тестирует метод CalculateArea класса Circle.
	/// </summary>
	[Test]
	public void CalculateAreaTest()
	{
		var circle = new Circle(5);

		var area = circle.CalculateArea();

		Assert.That(area, Is.EqualTo(78.53981633974483));
	}
}