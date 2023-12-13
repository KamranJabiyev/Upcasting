using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Models;

abstract class Animal
{
    public abstract void Breath();
    public virtual void Eat()
    {
        Console.WriteLine("Eat as Animal");
    }
}

class Bird:Animal
{
    public override void Breath()
    {
        Console.WriteLine("Breath as Bird");
    }

    public void Fly()
    {
        Console.WriteLine("Fly as bird");
    }
}

class Fish:Animal
{
    public override void Breath()
    {
        Console.WriteLine("Breath as Fish");
    }

    public sealed override void Eat()
    {
        Console.WriteLine("Eat as Fish");
    }
    public void Swim()
    {
        Console.WriteLine("Swimming as Fish");
    }
}

sealed class Shark: Fish, ILive
{
    public int Teeth { get; set; }
    //public override void Eat()
    //{
    //    Console.WriteLine("Eat as Shark");
    //}
    public override void Breath()
    {
        base.Breath();
    }

    public void Live()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return "Baby Shark";
    }

}

class Eagle : Bird,IRunable,ILive
{
    public int Age { get; set; }
    public override void Eat()
    {
        Console.WriteLine("");
    }

    public void Live()
    {
        throw new NotImplementedException();
    }

    public void Run()
    {
        throw new NotImplementedException();
    }
}


