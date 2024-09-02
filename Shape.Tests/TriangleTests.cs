using ShapeAreaCalcLib;
using ShapeAreaCalcLib.Extensions;

namespace Tests;

/// <summary>
/// Класс, содержащий тесты для проверки функциональности класса Triangle.
/// </summary>
public class TriangleTests
{
	/// <summary>
	/// Тестирует метод CalculateArea класса Triangle.
	/// </summary>
	[Test]
	public void CalculateAreaTest()
	{
		var triangle = new Triangle(3, 4, 5);

		var area = triangle.CalculateArea();

		Assert.That(area, Is.EqualTo(6));
	}

	
	/// <summary>
	/// Тестирует метод IsRightAngled класса Triangle.
	/// </summary>
	[Test]
	public void IsRightAngledTest()
	{
		var triangle = new Triangle(3, 4, 5);
		
		var isRightAngled = triangle.IsRightAngled();
		
		Assert.That(isRightAngled, Is.True);
	}
}