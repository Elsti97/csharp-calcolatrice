
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Somma singola: " + CalcoliHelper.somma(1, 2));
        Console.WriteLine("Somma Doppia: " + CalcoliHelper.somma(1.5, 3.6));

        Console.WriteLine("Differenza singola: " + CalcoliHelper.diff(5, 3));
        Console.WriteLine("Differenza Doppia: " + CalcoliHelper.diff(5.5, 3.1));

        Console.WriteLine("Moltiplicazione singola: " + CalcoliHelper.molt(2, 3));
        Console.WriteLine("Moltiplicazione Doppia: " + CalcoliHelper.molt(2.5, 3.5));

        Console.WriteLine("Divisione singola: " + CalcoliHelper.div(6, 3));
        Console.WriteLine("Divisione Doppia: " + CalcoliHelper.div(10.5, 0.2));

        Console.WriteLine("Assoluto singolo: " + CalcoliHelper.abs(-10));
        Console.WriteLine("Assoluto Doppio: " + CalcoliHelper.abs(-10.5));

        Console.WriteLine("Minimo singolo: " + CalcoliHelper.min(2, 3));
        Console.WriteLine("Minimo Doppio: " + CalcoliHelper.min(2.5, 3.5));

        Console.WriteLine("Massimo singolo: " + CalcoliHelper.max(2, 3));
        Console.WriteLine("Massimo Doppio: " + CalcoliHelper.max(2.5, 3.5));

        Console.WriteLine("Potenza 0 alla 0: " + CalcoliHelper.potenza(0, 0));
        Console.WriteLine("Potenza 0 alla 2: " + CalcoliHelper.potenza(0, 2));
        Console.WriteLine("Potenza 2 alla 0: " + CalcoliHelper.potenza(2, 0));
        Console.WriteLine("Potenza 2 alla -3: " + CalcoliHelper.potenza(2, -3));
        Console.WriteLine("Potenza 2 alla 4: " + CalcoliHelper.potenza(2, 4));
    }
}