using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankSistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente(132, 321);

            Console.WriteLine(cc.Numero);

            Console.ReadLine();
        }
    }
}
