﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankHeranca.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf)
        {
        }

        public override void AumentarSalario()
        {
            throw new NotImplementedException();
        }

        public override double GetBonificacao()
        {
            throw new NotImplementedException();
        }
    }
}
