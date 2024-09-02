using ShapeAreaCalcLib;

namespace Tests;

public class CircleTests
{
	[Test]
	public void CalculateAreaTest()
	{
		var circle = new Circle { Radius = 5 };

		var area = circle.CalculateArea();

		Assert.That(area, Is.EqualTo(78.53981633974483));
	}
}