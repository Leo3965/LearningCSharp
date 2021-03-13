using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao
{
    public partial class Program 
    { 
        static void Main(string[] args) 
        {
            //LidandoComStrean();
            //UsandoBBdeStram();
            //CriarArquivo();
            //CriarContaComWriter();

        }

        static void EscritaBinaria()
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
            using (var escritor = new BinaryWriter(fs))
            {
                escritor.Write(456);//número da Agência
                escritor.Write(546544);//número da conta
                escritor.Write(4000.50);//Saldo
                escritor.Write("Gustavo Braga");
            }
        }

        static void LeituraBinaria()
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
            using (var leitor = new BinaryReader(fs))
            {
                var agencia = leitor.ReadInt32();
                var numeroConta = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var titular = leitor.ReadString();

            }



        }
} 
 