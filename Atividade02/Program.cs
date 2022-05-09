using System;

namespace Atividade02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidadeDeAlunos = 0;
            int tempoDeChegada = 0;

            Console.Write("Digite a quantidade de alunos na sala: ");
            quantidadeDeAlunos = int.Parse(Console.ReadLine());

            SolicitacaoDoTempoDeChegadoDoAluno(quantidadeDeAlunos, tempoDeChegada);

            TeraAulaOuNao(quantidadeDeAlunos);
        }

        private static void TeraAulaOuNao(int quantidadeDeAlunos)
        {
            if (quantidadeDeAlunos < 3)
            {
                Console.WriteLine("Aula será cancelada por falta de alunos.");
            }
            else
            {
                Console.WriteLine("Aula normal.");
            }
        }

        private static int SolicitacaoDoTempoDeChegadoDoAluno(int quantidadeDeAlunos, int tempoDeChegada)
        {
            for (int i = 0; i < quantidadeDeAlunos; i++)
            {
                Console.Write("Digite o tempo de chegada dos alunos: ");
                tempoDeChegada = int.Parse(Console.ReadLine());
            }

            return tempoDeChegada;
        }
    }
}
