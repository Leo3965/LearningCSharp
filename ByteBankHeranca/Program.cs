﻿using ByteBankHeranca.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            //Funcionario carlos = new Funcionario();
            //carlos.Nome = "Carlos";
            //carlos.Cpf = "546.879.157-20";
            //carlos.Salario = 2000;

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor("123");
            roberta.Nome = "Roberta";
            //roberta.Cpf = "454.658.148-3";
            roberta.Salario = 5000;

            gerenciador.Registrar(roberta);
        }
    }
}
