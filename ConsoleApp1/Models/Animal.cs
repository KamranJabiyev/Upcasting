namespace ConsoleApp1.Models;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eat as Animal");
    }
}

class Bird:Animal
{
    public void Fly()
    {
        Console.WriteLine("Fly as bird");
    }
}

class Fish:Animal
{
    public void Swim()
    {
        Console.WriteLine("Swimming as Fish");
    }
}

class Shark: Fish
{
    public int Teeth { get; set; }
}

class Eagle : Bird
{
    public int Age { get; set; }
}


