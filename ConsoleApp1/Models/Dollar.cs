namespace ConsoleApp1.Models;

internal class Dollar
{
    public double USD { get; set; }
    public Dollar(double usd)
    {
        USD = usd;
    }

    public static implicit operator Manat(Dollar dollar)
    {
        return new Manat(dollar.USD * 1.7);
    }
}

internal class Manat
{
    public double AZN { get; set; }
    public Manat(double azn)
    {
        AZN = azn;
    }
    public static explicit operator Dollar(Manat manat)
    {
        return new Dollar(manat.AZN / 1.7);
    }
}
