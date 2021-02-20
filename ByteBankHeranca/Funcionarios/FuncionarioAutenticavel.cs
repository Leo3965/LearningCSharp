using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankHeranca.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        protected FuncionarioAutenticavel(double salario, string cpf) : base(salario,cpf)
        {
        }

        public override void AumentarSalario()
        {
            throw new NotImplementedException();
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

        public override double GetBonificacao()
        {
            throw new NotImplementedException();
        }
    }
}
