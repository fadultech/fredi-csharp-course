using System;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            decimal d = 1.33M;  // Utilizado para cálculos financeiros (moeda)
            double d2 = 1.33;   // Utilizado para cálculos científicos e medições
            float f = 1.33F;    // Utilizado com engines de jogos devido à performance (Unity)
        }
    }
}
