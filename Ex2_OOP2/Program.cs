using System;

abstract class Animal
{
    protected string Type { get; }

    protected Animal(string type)
    {
        Type = type;
    }

    public abstract string MakeSound();
    public abstract string GetInfo();
}

class Dog : Animal
{
    public string Breed { get; }
    public string Name { get; }

    public Dog(string breed, string name) : base("mammal")
    {
        Breed = breed;
        Name = name;
    }

    public override string MakeSound()
    {
        return "Woof Woof!";
    }

    public override string GetInfo()
    {
        return $"Type: {Type}, Breed: {Breed}, Name: {Name}";
    }
}

class Cat : Animal
{
    public string Name { get; }

    public Cat(string name) : base("mammal")
    {
        Name = name;
    }

    public void Climb(string where)
    {
        Console.WriteLine($"Cat {Name} is climbing {where}.");
    }

    public override string MakeSound()
    {
        return "Meow!";
    }

    public override string GetInfo()
    {
        return $"Type: {Type}, Name: {Name}";
    }
}

class Duck : Animal
{
    public string Name { get; }

    public Duck(string name) : base("bird")
    {
        Name = name;
    }

    public void Swim(string where)
    {
        Console.WriteLine($"Duck {Name} is swimming in {where}.");
    }

    public override string MakeSound()
    {
        return "Quack!";
    }

    public override string GetInfo()
    {
        return $"Type: {Type}, Name: {Name}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("Spaniel", "Buddy");
        Cat cat = new Cat("Whiskers");
        Duck duck = new Duck("Daffy");

        Console.WriteLine(dog.GetInfo());
        Console.WriteLine($"Sound: {dog.MakeSound()}");

        Console.WriteLine(cat.GetInfo());
        Console.WriteLine($"Sound: {cat.MakeSound()}");
        cat.Climb("a tree");

        Console.WriteLine(duck.GetInfo());
        Console.WriteLine($"Sound: {duck.MakeSound()}");
        duck.Swim("a pond");
    }
}

