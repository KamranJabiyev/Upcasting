namespace ConsoleApp1.Models;

public class Fahrenheit
{
    public double fanarhet { get; set; }

    public Fahrenheit(double _fanarhet)
    {
        fanarhet = _fanarhet;
    }

    public static implicit operator Fahrenheit(Celsius celsius1)
    {
       return new Fahrenheit((celsius1.celsius * 1.8) + 32);
    }

}
