using System;

namespace Atividade01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                if((i + ReverterNumero(i)) % 2 != 0)
                {
                    Console.WriteLine($"Número: {i} " +
                        $"+ Número Reverso: {ReverterNumero(i)} " +
                        $"= Soma do número ímpar: {i + ReverterNumero(i)}");
                }
            }
        }

        public static int ReverterNumero(int numero)
        {
            int resultado = 0;

            while(numero > 0)
            {
                resultado = 10 * resultado + numero % 10;
                numero /= 10;
            }
            return resultado;
        }
    }
}
