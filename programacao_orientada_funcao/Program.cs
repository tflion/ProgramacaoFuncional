using System;
using System.Collections.Generic;
using System.IO;

namespace programacao_orientada_funcao
{
    class Program
    {

        private static void CalcularMediaAluno()
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
                Console.Write("\n  Digite a " + i + "º nota do aluno " + nome +": ");
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

            foreach(int nota in notas)
            {              
                Console.WriteLine("            Nota: " + nota + "\n");           
            }

            Console.WriteLine("");
            Console.WriteLine("                                         Pressione 'ENTER' para retornar ao menu. ");
            Console.ReadLine();
        }

        public static void Tabuada(int numero)
        {
            Console.WriteLine("                                                  * Tabuada do número " + numero + " *");
            Console.WriteLine("");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("                                                        " + numero + " x " + i + " = " + (numero * i));
            }
            Console.WriteLine("");
            Console.WriteLine("                                         Pressione 'ENTER' para retornar ao menu. ");
            Console.ReadLine();
        }

        private static void LerArquivo(int numeroArquivo)
        {

            
                string arquivoComCaminho = @"C:\arquivosCSharp\arq" + numeroArquivo + ".txt";
                Console.WriteLine("");
                Console.WriteLine("|--------------------------------------------------|");
                Console.WriteLine(" * Arquivo (" + arquivoComCaminho + ") abaixo: " );
                if (File.Exists(arquivoComCaminho))
                {
                    using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                    {
                        string linha;
                        Console.WriteLine("\n");
                        while ((linha = arquivo.ReadLine()) != null)
                        {
                            Console.WriteLine(linha);

                        }
                    }
                }

                string arquivoComCaminho2 = @"C:\arquivosCSharp\arq" + (numeroArquivo + 1) + ".txt";
                if (File.Exists(arquivoComCaminho2))
                {
                    LerArquivo(numeroArquivo + 1);
                }

            
        }

        private static void Menu()
        {
            while (true)
            {
                Console.Clear();
                string mensagem = "                                        Olá usuário, bem vindo ao programa!" +
                    "\n                                         Utilizando programação funcional." +
                    "\n" +
                    "\n                                          Escolha uma das opções abaixo: " +
                    "\n" +
                    "\n                                            [0] - Sair do programa" +
                    "\n                                            [1] - Ler arquivos" +
                    "\n                                            [2] - Executar a tabuada" +
                    "\n                                            [3] - Calcular a média de um aluno" +
                    "\n" +
                    "\n * Sua escolha: ";

                Console.Write(mensagem);
                int valor = int.Parse(Console.ReadLine());


                if (SAIDA_PROGRAMA == valor)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.Clear();
                    Console.Write("");
                    Console.WriteLine("                                                  * Leitura de arquivos * ");
                    LerArquivo(1);
                    Console.WriteLine("");
                    Console.WriteLine("                                           Pressione 'ENTER' para retornar ao menu. ");
                    Console.ReadLine();
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("\n");
                    Console.Write("Qual número deseja saber a tabuada: ");
                    int numero = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Tabuada(numero);
                }
                else if (valor == CALCULO_MEDIA)
                {
                    CalcularMediaAluno();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("                                           * OPÇÃO INVÁLIDA DIGITE NOVAMENTE * ");
                    Console.WriteLine("");
                    Console.WriteLine("                                            Pressione 'ENTER' para continuar. ");
                    Console.ReadLine();
                }
            }
        }

        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;

        
        
        
        static void Main(string[] args)
        {
            Menu();
        }
    }
}
