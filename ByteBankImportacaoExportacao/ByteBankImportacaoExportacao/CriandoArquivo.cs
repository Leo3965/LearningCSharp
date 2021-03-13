using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    public partial class Program
    {
        public static void CriarArquivo()
        { 
            var fileNewPath = "contasExported.txt";

            using (var fs = new FileStream(fileNewPath, FileMode.Create))
            {
                var contaAsString = "456, 78946,4785.50,Gustava Santos";
                var encoding = Encoding.UTF8;
                var bytes = encoding.GetBytes(contaAsString);

                fs.Write(bytes, 0, bytes.Length);
            }
        }
    }
}
