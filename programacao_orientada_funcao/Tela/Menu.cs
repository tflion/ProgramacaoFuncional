using Calculo;
using Diretorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tela
{
    class Menu
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;

        public static void Criar()
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
                    Arquivo.Ler(1);
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
                    Tabuada.Calcular(numero);
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Media.Aluno();
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
    }
}
