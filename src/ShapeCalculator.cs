using System;
using System.Linq; // Necessary for using Sum() method in the perimeter calculation for the triangle

public enum Shape
{
  Circle,
  Rectangle,
  Triangle,
  Square,
  Pentagon,
  Hexagon
  // Add other shapes as needed
}

public class ShapeCalculator
{
  // Method to calculate the area of a shape
  public static double CalculateArea(Shape shape, params double[] dimensions)
  {
    switch (shape)
    {
      case Shape.Circle:
        if (dimensions.Length == 1)
        {
          double radius = dimensions[0];
          return Math.PI * radius * radius;
        }
        break;
      case Shape.Rectangle:
        if (dimensions.Length == 2)
        {
          double length = dimensions[0];
          double width = dimensions[1];
          return length * width;
        }
        break;
      case Shape.Triangle:
        if (dimensions.Length == 3)
        {
          double a = dimensions[0];
          double b = dimensions[1];
          double c = dimensions[2];
          double s = (a + b + c) / 2;
          return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
        break;
      case Shape.Square:
        if (dimensions.Length == 1)
        {
          double side = dimensions[0];
          return side * side;
        }
        break;
      case Shape.Pentagon:
        if (dimensions.Length == 1)
        {
          double side = dimensions[0];
          return 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * side * side;
        }
        break;
      case Shape.Hexagon:
        if (dimensions.Length == 1)
        {
          double side = dimensions[0];
          return (3 * Math.Sqrt(3) * side * side) / 2;
        }
        break;
      // Add other shapes as needed
    }
    throw new ArgumentException("Invalid shape or dimensions");
  }

  // Method to calculate the perimeter of a shape
  public static double CalculatePerimeter(Shape shape, params double[] dimensions)
  {
    switch (shape)
    {
      case Shape.Circle:
        if (dimensions.Length == 1)
        {
          double radius = dimensions[0];
          return 2 * Math.PI * radius;
        }
        break;
      case Shape.Rectangle:
        if (dimensions.Length == 2)
        {
          double length = dimensions[0];
          double width = dimensions[1];
          return 2 * (length + width);
        }
        break;
      case Shape.Triangle:
        if (dimensions.Length == 3)
        {
          return dimensions.Sum();
        }
        break;
      case Shape.Square:
        if (dimensions.Length == 1)
        {
          double side = dimensions[0];
          return 4 * side;
        }
        break;
      case Shape.Pentagon:
        if (dimensions.Length == 1)
        {
          double side = dimensions[0];
          return 5 * side;
        }
        break;
      case Shape.Hexagon:
        if (dimensions.Length == 1)
        {
          double side = dimensions[0];
          return 6 * side;
        }
        break;
      // Add other shapes as needed
    }
    throw new ArgumentException("Invalid shape or dimensions");
  }
}
