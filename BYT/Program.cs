using Tut2_s20123;
using BYT;

//Part 1

Console.WriteLine("Hello, World!");
IShape sphere = new Sphere(5);
Console.WriteLine("Sphere:");
Console.WriteLine($"Area: {sphere.CalculateArea():F3}");
Console.WriteLine($"Volume: {sphere.CalculateVolume():F3}");
Console.WriteLine();

IShape cylinder = new Cylinder(3, 7);
Console.WriteLine("Cylinder:");
Console.WriteLine($"Area: {cylinder.CalculateArea():F3}");
Console.WriteLine($"Volume: {cylinder.CalculateVolume():F3}");
Console.WriteLine();

IShape rectangle = new Rectangle(4, 8);
Console.WriteLine("Rectangle:");
Console.WriteLine($"Area: {rectangle.CalculateArea():F3}");
Console.WriteLine($"Volume: {rectangle.CalculateVolume():F3}");
Console.WriteLine();

IShape cube = new Cube(4);
Console.WriteLine("Cube:");
Console.WriteLine($"Area: {cube.CalculateArea():F3}");
Console.WriteLine($"Volume: {cube.CalculateVolume():F3}");
Console.WriteLine();

// Part 2

Calculator calc1 = new Calculator(10, 5, "+");
Console.WriteLine($"{calc1.A} + {calc1.B} = {calc1.Calculate()}");
Calculator calc2 = new Calculator(10, 5, "-");
Console.WriteLine($"{calc2.A} - {calc2.B} = {calc2.Calculate()}");
Calculator calc3 = new Calculator(10, 5, "*");
Console.WriteLine($"{calc3.A} * {calc3.B} = {calc3.Calculate()}");
Calculator calc4 = new Calculator(10, 5, "/");
Console.WriteLine($"{calc4.A} / {calc4.B} = {calc4.Calculate()}");
try
{
    Calculator calc5 = new Calculator(10, 0, "/");
    Console.WriteLine($"{calc5.A} / {calc5.B} = {calc5.Calculate()}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}