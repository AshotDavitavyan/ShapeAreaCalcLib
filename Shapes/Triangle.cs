using ShapeAreaCalcLib.Shapes;

namespace ShapeAreaCalcLib;

public class Triangle : IShape
{
	public double Side1 { get; set; }
	public double Side2 { get; set; }
	public double Side3 { get; set; }

	public Triangle(double side1, double side2, double side3)
	{
		Side1 = side1;
		Side2 = side2;
		Side3 = side3;
	}
	
	public double CalculateArea()
	{
		double s = (Side1 + Side2 + Side3) / 2;
		return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
	}
	
	public bool IsRightAngled()
	{
		double[] sides = { Side1, Side2, Side3 };
		Array.Sort(sides);
		return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
	}
}