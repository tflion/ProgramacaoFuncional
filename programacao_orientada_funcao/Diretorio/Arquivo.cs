using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Diretorio
{
    class Arquivo
    {
        public static void Ler(int numeroArquivo)
        {


            string arquivoComCaminho = @"C:\arquivosCSharp\arq" + numeroArquivo + ".txt";
            Console.WriteLine("");
            Console.WriteLine("|--------------------------------------------------|");
            Console.WriteLine(" * Arquivo (" + arquivoComCaminho + ") abaixo: ");
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
                Arquivo.Ler(numeroArquivo + 1);
            }


        }
    }
}
