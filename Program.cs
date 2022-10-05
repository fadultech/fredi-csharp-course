using System;

namespace dotnetcore
{
    class Program
    {
        static void Main()
        {
            Test t = new Test();
            t.x = 10;

            Test t2 = t1;
            t2.x = 20;

            Console.WriteLine(t.x);
            Console.WriteLine(t2.x);

        }

    }
    class Test
    {
        public int x;
    }

}



