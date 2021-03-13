using System;
using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao
{
    public partial class Program
    {
        public static void CriarContaComWriter()
        {
            var fileNewPath = "contasExported.txt";

            using (var fs = new FileStream(fileNewPath, FileMode.Create))
            using (var sw = new StreamWriter(fs, Encoding.UTF8))
            {
                sw.Write("456,654564654,4563.30,Pedro");
            }
        }

        public static void TestaEscrita()
        {
            var caminhoArquivo = "teste.txt";

            using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                for (int i = 0; i < 1000000000; i++)
                {
                    escritor.WriteLine($"Linha {i}");
                    escritor.Flush(); // Despeja o buffer para o Stream;

                    Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter p adicionar mais uma!");
                    Console.ReadLine();
                }
            }
        }
    }


}

