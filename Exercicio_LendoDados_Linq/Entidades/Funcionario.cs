﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_LendoDados_Linq.Entidades
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome,string email, double salario)
        {
            Nome = nome;
            Email = email;
            Salario = salario;

        }
               
    }
}
