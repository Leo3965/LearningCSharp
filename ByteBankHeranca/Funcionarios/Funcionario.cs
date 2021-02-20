using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankHeranca.Funcionarios
{
    public abstract class Funcionario
    {

        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; set; }
        public Funcionario(String cpf)
        {
            this.Cpf = cpf;
            Funcionario.TotalDeFuncionarios++;
        }

        protected Funcionario(double salario, string cpf)
        {
            Salario = salario;
            Cpf = cpf;
        }

        public abstract double GetBonificacao();
        public abstract void AumentarSalario();

    }
}
