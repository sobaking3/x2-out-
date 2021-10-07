using System;


namespace x2
{
    class Program
    {
        static void Main(string[] args)
        {
            string dada;
            new Reshenie(1, 8, 0).raschet(out dada);
            Console.WriteLine(dada);
        }
    }
    class Reshenie
    {
        private double a;
        private double b;
        private double c;
        private double D;
        private double x1;
        private double x2;
        public string dada = " ";
        public Reshenie(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            // this.dada = " ";
        }
        public void raschet(out string dada)
        {
            dada = " ";
            D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0 || D == 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                dada = $"x1={x1} x2={x2}";
            }
            else
            {
                dada = "Корней нет";
            }
        }
    }
}
            
    