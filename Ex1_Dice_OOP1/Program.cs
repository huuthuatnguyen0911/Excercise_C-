using System;

class Dice
{
    private int sides;
    private Random random;

    public Dice(int sides)
    {
        this.sides = sides;
        random = new Random();

    }
    public int Roll()
    {
        return random.Next(1, sides+1);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap so mat cho vien xuc xac: ");
        int sides = int.Parse(Console.ReadLine());

        Dice dice = new Dice(sides);

        Console.WriteLine("Do xuc xac ...");
        int result = dice.Roll();
        Console.WriteLine("Ket qua la: " + result);
    }
}