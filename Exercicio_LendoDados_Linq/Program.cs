using System;
using System.IO;
using Exercicio_LendoDados_Linq.Entidades;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Exercicio_LendoDados_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> ListaFuncionarios = new List<Funcionario>();

            Console.Write("Informe o caminho do arquivo que será lido: ");
            string Caminho = Console.ReadLine();

            Console.Write("Qual o valor do salarioa a ser lido: ");
            double Valor = double.Parse(Console.ReadLine());

            //Leitura e captaçao de dados
            using (StreamReader sr = File.OpenText(Caminho))
            {
                while (!sr.EndOfStream)
                {
                    string[] campos = sr.ReadLine().Split(',');
                    string nome = campos[0];
                    string email = campos[1];
                    double salario = double.Parse(campos[2]);

                    ListaFuncionarios.Add(new Funcionario(nome, email, salario));

                }

            }

            var soma = ListaFuncionarios
                .Where(p => p.Nome[0] == 'M')
                .Sum(p => p.Salario);


            var emails = ListaFuncionarios
                .Where(p => p.Salario > Valor).OrderBy(p=>p.Nome)
                .Select(p => p.Email);


            Console.WriteLine("Email dos funcionarios com salarioa abaixo de: " + Valor.ToString("F2"));
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=");
            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.Write("Soma dos salarios dos funcionarios que começam com a letra 'M' " + soma.ToString("F2") );





        }
    }
}
