using System;
using System.Collections.Generic;
using System.Text;

namespace Calculo
{
    class Media
    {
        public static void Aluno()
        {
            Console.Clear();
            Console.WriteLine("                                            * Calcular Média Aluno * ");
            Console.WriteLine("");
            Console.Write("> Informe o nome do aluno: ");
            string nome = Console.ReadLine();

            List<double> notas = new List<double>();

            Console.Write("\n> Quantas notas serão calculadas: ");
            int qtNotas = int.Parse(Console.ReadLine());

            double totalNotas = 0;


            for (int i = 1; i <= qtNotas; i++)
            {
                Console.Write("\n  Digite a " + i + "º nota do aluno " + nome + ": ");
                int nota = int.Parse(Console.ReadLine());
                totalNotas += nota;
                notas.Add(nota);
            }

            double media = (totalNotas / notas.Count);

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("* A média do aluno " + nome + " é: " + media);
            Console.WriteLine("");
            Console.WriteLine("           Suas notas são: \n");

            foreach (int nota in notas)
            {
                Console.WriteLine("            Nota: " + nota + "\n");
            }

            Console.WriteLine("");
            Console.WriteLine("                                         Pressione 'ENTER' para retornar ao menu. ");
            Console.ReadLine();
        }

    }
}
