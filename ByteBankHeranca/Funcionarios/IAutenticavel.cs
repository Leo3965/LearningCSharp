using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankHeranca.Funcionarios
{
    public interface IAutenticavel 
    {
        bool Autenticar(string senha);
    }
}
