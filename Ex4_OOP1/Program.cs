using System;

class Fraction
{
    private int numerator;
    private int denominator;

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Denominator cannot be zero.");

        this.numerator = numerator;
        this.denominator = denominator;
        Normalize();
    }

    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    private void Normalize()
    {
        int gcd = GCD(numerator, denominator);
        numerator /= gcd;
        denominator /= gcd;

        if (denominator < 0)
        {
            numerator = -numerator;
            denominator = -denominator;
        }
    }

    public static Fraction Add(Fraction a, Fraction b)
    {
        int newNumerator = a.numerator * b.denominator + b.numerator * a.denominator;
        int newDenominator = a.denominator * b.denominator;
        return new Fraction(newNumerator, newDenominator);
    }

    public static Fraction Subtract(Fraction a, Fraction b)
    {
        int newNumerator = a.numerator * b.denominator - b.numerator * a.denominator;
        int newDenominator = a.denominator * b.denominator;
        return new Fraction(newNumerator, newDenominator);
    }

    public static Fraction Multiply(Fraction a, Fraction b)
    {
        int newNumerator = a.numerator * b.numerator;
        int newDenominator = a.denominator * b.denominator;
        return new Fraction(newNumerator, newDenominator);
    }

    public static Fraction Divide(Fraction a, Fraction b)
    {
        if (b.numerator == 0)
            throw new DivideByZeroException("Khong the chia cho 0");

        int newNumerator = a.numerator * b.denominator;
        int newDenominator = a.denominator * b.numerator;
        return new Fraction(newNumerator, newDenominator);
    }

    public double ToDecimal()
    {
        return (double)numerator / denominator;
    }

    public override string ToString()
    {
        return "(" + numerator + "/" + denominator + ")";
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Fraction fraction1 = new Fraction(1, 2);
            Fraction fraction2 = new Fraction(3, 4);

            Console.WriteLine("Fraction 1: " + fraction1);
            Console.WriteLine("Fraction 2: " + fraction2);

            Fraction sum = Fraction.Add(fraction1, fraction2);
            Console.WriteLine("Sum: " + sum);

            Fraction difference = Fraction.Subtract(fraction1, fraction2);
            Console.WriteLine("Difference: " + difference);

            Fraction product = Fraction.Multiply(fraction1, fraction2);
            Console.WriteLine("Product: " + product);

            Fraction quotient = Fraction.Divide(fraction1, fraction2);
            Console.WriteLine("Quotient: " + quotient);

            Console.WriteLine("Fraction 1 as decimal: " + fraction1.ToDecimal());
            Console.WriteLine("Fraction 2 as decimal: " + fraction2.ToDecimal());
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
