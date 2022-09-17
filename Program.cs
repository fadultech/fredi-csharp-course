using System;

namespace dotnetcore
{
    class Program
    {
        static void Main()
        {
            // usando array
            string[] names = { "Fredi", "Carlos" };
            // Strings são Case Sensitive
            if(names[0]=="fredi")
            {
                Console.WriteLine("Igual");
            }else {
            // Usando Foreach
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            }

        }

    }
}



