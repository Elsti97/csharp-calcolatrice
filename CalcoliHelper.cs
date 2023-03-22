using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


    //Polimorfismo, più metodi definiti con lo stesso nome, numero diverso di parametri
    public static class CalcoliHelper
    {
        public static int somma(int a, int b)=>(a + b);
        public static double somma(double a, double b)=>(a + b);

        public static int diff(int a, int b) => (a - b);
        public static double diff(double a, double b) => (a - b);

        public static int molt(int a, int b) => (a * b);
        public static double molt(double a, double b) => (a * b);

        public static int div(int a, int b)=> (a / b);
        public static double div(double a, double b) => (a / b);

        public static int abs(int a)=>(Math.Abs(a));
        public static double abs(double a) =>(Math.Abs(a));

        public static int min(int a, int b)=>(Math.Min(a, b));
        public static double min(double a, double b)=>(Math.Min(a, b));

        public static int max(int a, int b) => (Math.Max(a, b));
        public static double max(double a, double b) => (Math.Max(a, b));


    //BONUS
    public static double potenza(int a, int b)
    {
        if (a == 0 && b == 0)
        {
            return 1;
        }
        else if (b == 0)
        {
            return 1;
        }
        else if (a == 0)
        {
            return 0;
        }
        else if (b < 0)
        {
            return 1 / potenza(a, -b);
        }
        else
        {
            int risultato = a;
            for (int i = 1; i < b; i++)
            {
                risultato *= a;
            }
            return risultato;
        }
    }
}


