using System;

abstract class Shape
{
    protected int x;
    protected int y;

    public Shape(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void Move(int dx, int dy)
    {
        x += dx;
        y += dy;
    }

    public abstract void Show();
}

class Line : Shape
{
    private int x2;
    private int y2;

    public Line(int x1, int y1, int x2, int y2) : base(x1, y1)
    {
        this.x2 = x2;
        this.y2 = y2;
    }

    public override void Show()
    {
        Console.WriteLine($"Line from ({x}, {y}) to ({x2}, {y2})");
    }
}

class Circle : Shape
{
    private int radius;

    public Circle(int x, int y, int radius) : base(x, y)
    {
        this.radius = radius;
    }
    public override void Show()
    {
        Console.WriteLine($"Circle at ({x}, {y}) with radius {radius}");
    }

}

class Rectangle : Shape
{
    private int x2;
    private int y2;
    private int x3;
    private int y3;

    public Rectangle(int x1, int y1, int x2, int y2, int x3, int y3) : base(x1, y1)
    {
        this.x2 = x2;
        this.y2 = y2;
        this.x3 = x3;
        this.y3 = y3;
    }

    public override void Show()
    {
        Console.WriteLine($"Rectangle with points: ({x}, {y}), ({x2}, {y2}), ({x3}, {y3})");
    }
}

class PolyLine : Shape
{
    public PolyLine(int x, int y) : base(x, y)
    {
    }

    public override void Show()
    {
        Console.WriteLine($"PolyLine starting at ({x}, {y})");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape line = new Line(1, 2, 3, 4);
        Shape circle = new Circle(5, 6, 7);
        Shape rectangle = new Rectangle(8, 9, 10, 11, 12, 13);
        Shape polyLine = new PolyLine(14, 15);

        line.Show();
        circle.Show();
        rectangle.Show();
        polyLine.Show();
    }
}