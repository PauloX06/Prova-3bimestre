using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_3_Bimestre.classes
{
    internal class Administrativo:Funcionario
    {
        public string Funcao { get; set; }

        public Administrativo(string nome, string cpf, string matricula, DateTime datanascimento, string sexo, double salario, string funcao)
            : base(nome, cpf , matricula, datanascimento, sexo, salario)
        {
            Funcao = funcao;
        }
        public double CalcularValeTransporte()
        {
            return 150.0;
        }

        public double CalcularValeAlimentacao()
        {
            return Salario * 0.15;
        }
    }
}
    

