namespace ConsoleApp1.Models;

public class Celsius
{
    public double celsius { get; set; }

    public Celsius(double _celsius)
    {
        celsius = _celsius;
    }

    public static explicit operator Celsius(Fahrenheit fahrenheit1)
    {
        return new Celsius((fahrenheit1.fanarhet - 32) *5/9);
    }
}
