using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_3_Bimestre.classes
{
    internal class Medico:Funcionario
    {
        public string CRM { get; set; }
        public double ValorHoraExtra { get ; set; } 
        public string Especialidade { get; set; }


        public Medico(string nome, string cpf, string matricula, DateTime datanascimento, string sexo, double salario, string crm, double valorhoraextra, string especialidade) 
            : base(nome, cpf, matricula, datanascimento, sexo, salario)
            
        { 
            CRM = crm;
            ValorHoraExtra = valorhoraextra;
            Especialidade = especialidade;

        }

        public double CalcularAuxilio()
        {
            return Salario * 0.2;
        }

    }
}
