using System;

namespace ClassStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Bakiye bakiyeIslemi = new Bakiye();

            decimal sonuc = bakiyeIslemi.Yekun(1500, 500);
            Console.WriteLine("Kalan yekun: " + sonuc);
        } 
    }
    class Bakiye
    {
        public decimal Y(decimal a, decimal b)
        {
            return a - b;
        }
        public decimal Yekun(decimal alacak, decimal borc)
        {
            return alacak - borc;
        }
        
    }
}
