using System;

class Person
{
    private String name;
    private int age;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Person() { }

    public Person(String name, int age) {
        this.name = name;
        this.age = age;
    }

    public void DisplayPerson()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

    public void Input()
    {
        Console.WriteLine("Nhap ten: ");
        Name = Console.ReadLine();
        Console.WriteLine("Nhap tuoi: ");
        Age = int.Parse(Console.ReadLine());    
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}

class Student : Person
{
    private double gpa;

    public double Gpa
    {
        get { return gpa; }
        set { gpa = value; }
    }
    public Student(double gpa, string name, int age)
    {
        this.gpa = gpa;
    }

    public Student()
    {

    }

    public void DisplayStudent()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Gpa: {Gpa}");
    }

    public new void Input()
    {
        base.Input();
        Console.WriteLine("Nhap Gpa: ");
        Gpa = double.Parse(Console.ReadLine());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.Input();
        student.DisplayStudent();
    }
}

