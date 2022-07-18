using System;

namespace tabuada
{
    class Program
    {
    
        static void Main(string[] args)

        {
            int fator, resultado ;
            Console.WriteLine("Escreva qual numero quer multiplicar");
            fator = int.Parse(Console.ReadLine());


            for (int y = 1; y <= 10; y++)
            {
                resultado = fator * y;
                Console.WriteLine(fator + " x " + y + " = "+ resultado);
            }
        }
    }
}
