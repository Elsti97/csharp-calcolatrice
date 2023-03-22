
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Somma singola: " + CalcoliHelper.sommaInt(1, 2));
        Console.WriteLine("Somma Doppia: " + CalcoliHelper.sommaDouble(1.5, 3.6));

        Console.WriteLine("Differenza singola: " + CalcoliHelper.diffInt(5, 3));
        Console.WriteLine("Differenza Doppia: " + CalcoliHelper.diffDouble(5.5, 3.5));

        Console.WriteLine("Moltiplicazione singola: " + CalcoliHelper.moltInt(2, 3));
        Console.WriteLine("Moltiplicazione Doppia: " + CalcoliHelper.moltDouble(2.5, 3.5));

        Console.WriteLine("Divisione singola: " + CalcoliHelper.divInt(6, 3));
        Console.WriteLine("Divisione Doppia: " + CalcoliHelper.divDouble(10.5, 0.1));

        Console.WriteLine("Assoluto singolo: " + CalcoliHelper.absInt(-10));
        Console.WriteLine("Assoluto Doppio: " + CalcoliHelper.absDouble(-10.5));

        Console.WriteLine("Minimo singolo: " + CalcoliHelper.minInt(2, 3));
        Console.WriteLine("Minimo Doppio: " + CalcoliHelper.minDouble(2.5, 3.5));

        Console.WriteLine("Massimo singolo: " + CalcoliHelper.maxInt(2, 3));
        Console.WriteLine("Massimo Doppio: " + CalcoliHelper.maxDouble(2.5, 3.5));
    }
}