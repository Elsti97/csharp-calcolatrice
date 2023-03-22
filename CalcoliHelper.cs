using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

    public class CalcoliHelper
    {
        public static int sommaInt(int a, int b)=>(a + b);
        public static double sommaDouble(double a, double b)=>(a + b);

        public static int diffInt(int a, int b) => (a - b);
        public static double diffDouble(double a, double b) => (a - b);

        public static int moltInt(int a, int b) => (a * b);
        public static double moltDouble(double a, double b) => (a * b);

        public static int divInt(int a, int b)=> (a / b);
        public static double divDouble(double a, double b) => (a / b);

        public static int absInt(int a)=>(Math.Abs(a));
        public static double absDouble(double a) =>(Math.Abs(a));

        public static int minInt(int a, int b)=>(Math.Min(a, b));
        public static double minDouble(double a, double b)=>(Math.Min(a, b));

        public static int maxInt(int a, int b) => (Math.Max(a, b));
        public static double maxDouble(double a, double b) => (Math.Max(a, b));
    }


