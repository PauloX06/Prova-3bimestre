using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Prova_3_Bimestre.classes
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public double Salario { get; set; }

        public Funcionario()
        {

        }
        public Funcionario(string nome, string cpf, string matricula, DateTime datanascimento, string sexo, double salario)
        { 
            Nome = nome;
            Cpf = cpf;
            Matricula = matricula;
            DataNascimento = datanascimento;
            Sexo = sexo;
            Salario = salario;

        }
        
       
    }

    
}
