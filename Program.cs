using System;

namespace dotnetcore
{
    class Program
    {
        public int versao;
        static void Main(string[] args)
        {
            // Tipagem de variáveis
            int x = 10;
            decimal d = 1.33M;  // Utilizado para cálculos financeiros (moeda)
            double d2 = 1.33;   // Utilizado para cálculos científicos e medições
            float f = 1.33F;    // Utilizado com engines de jogos devido à performance (Unity)
            int y = x *2;
            string s = "Olá";
            s += " Mundo!";

            // Usando vetor
            int[] a = new int[] {2, 5, 7};
            int result = 0;
            foreach (int number in a)
            {
                result += number;
            }

            // Usando classes e objetos
            Program p = new Program();
            p.versao = 12;
            Test t = new Test();
            t.name = "Jairo";
            string hello = t.SayHello();

            // Imprimindo
            Console.WriteLine(s);
            Console.WriteLine(result);
            Console.WriteLine(p.versao);
            Console.WriteLine(hello);

        }
    }

    class Test{
        public string name;

        public string SayHello(){
            return "Olá " + name;
        }
    }
}
