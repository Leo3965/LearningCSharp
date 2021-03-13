using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;

namespace ByteBankImportacaoExportacao
{
    public partial class Program
    {

        public static void UsandoBBdeStram()
        {
            var filePath = "contas.txt";
            var contasCorrentes = new List<ContaCorrente>();

            using (var fileStream = new FileStream(filePath, FileMode.Open))
            {
                using (var reader = new StreamReader(fileStream))
                {
                    //var  line = reader.ReadToEnd();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();

                        var contaCorrente = ConverterStringToContaCorrente(line);
                        contasCorrentes.Add(contaCorrente);

                        var msg = ($"{contaCorrente.Titular.Nome} Número Conta: {contaCorrente.Numero}, ag. {contaCorrente.Agencia}. Saldo: {contaCorrente.Saldo}");
                        Console.WriteLine(msg);
                    }
                }
            }

            Console.ReadLine();
        }

        static ContaCorrente ConverterStringToContaCorrente(string line)
        {
            var fields = line.Split(',');

            var agencia = int.Parse(fields[0]);
            var conta = int.Parse(fields[1]);
            var saldo = double.Parse((fields[2]).Replace('.', ','));
            var titular = fields[3];

            var result = new ContaCorrente(agencia, conta);
            result.Depositar(saldo);
            result.Titular = new Cliente();
            result.Titular.Nome = titular;

            return result;
        }

    }
}
