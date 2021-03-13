using ByteBankImportacaoExportacao.Modelos;
using System;
using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao
{
    public partial class Program
    {
        static void LidandoComStrean()
        {

            var conta = new ContaCorrente();

            var filePath = "contas.txt";

            using (var stream = new FileStream(filePath, FileMode.Open))
            {
                var buffer = new byte[1024]; // 1 kb
                var bytesNumber = -1;

                while (bytesNumber != 0)
                {
                    bytesNumber = stream.Read(buffer, 0, 1024);
                    WriteBuffer(buffer, bytesNumber);
                }

                Console.ReadLine();
            }
        }

        static void WriteBuffer(byte[] buffer, int bytesNumber)
        {
            var utf8 = new UTF8Encoding();
            var text = utf8.GetString(buffer, 0, bytesNumber);
            Console.Write(text);
        }
    }
}
