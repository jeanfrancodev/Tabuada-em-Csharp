using System;

namespace tabuada
{
    class Program
    {
    
        static void Main(string[] args)

        {
            int fator ;
            Console.WriteLine("Escreva qual numero quer multiplicar");
            fator = int.Parse(Console.ReadLine());


            for (int y = 0; y <= 10; y++)
            {
              
                Console.WriteLine(fator + " x " + y + " = "+ fator * y);
            }
        }
    }
}
