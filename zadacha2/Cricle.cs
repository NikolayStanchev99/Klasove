using System;

public class Class1
{
	public Class1()
	{
		
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    
    public double CalculateCircumference()
    {
        return 2 * Math.PI * Radius;
    }

    
    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}
