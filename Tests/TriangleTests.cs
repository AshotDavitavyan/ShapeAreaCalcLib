using ShapeAreaCalcLib;

namespace Tests;

public class TriangleTests
{
	[Test]
	public void CalculateAreaTest()
	{
		var triangle = new Triangle(3, 4, 5);

		var area = triangle.CalculateArea();

		Assert.That(area, Is.EqualTo(6));
	}

	[Test]
	public void IsRightAngledTest()
	{
		var triangle = new Triangle(3, 4, 5);
		
		var isRightAngled = triangle.IsRightAngled();
		
		Assert.That(isRightAngled, Is.True);
	}
}