using System;

namespace Atividade03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numElementos;
            int[] meuArray;

            Console.Write("Infome o número de elementos:");
            numElementos = Convert.ToInt32(Console.ReadLine());

            meuArray = new int[numElementos];

            for (int i = 0; i < numElementos; i++)
            {
                Console.Write("Informe a posição do número: ");
                meuArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var item in meuArray)
            {
                var valor = item + item == numElementos;

                if (valor)
                {
                    Console.WriteLine($"Valor: {item}");
                }
            }
        }
    }
}
