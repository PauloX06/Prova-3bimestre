using Prova_3_Bimestre.classes;
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 para Funcionario:");
            Console.WriteLine("2 para Medico:");
            Console.WriteLine("3 para Administrativo:");

            int opcao = Convert.ToInt32(Console.ReadLine());

           if(opcao == 1)
            {
                List<Funcionario> list = new List<Funcionario>();
                Funcionario a = new Funcionario();

                Console.WriteLine("Digite o nome:");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o cpf: ");
                string cpf = Console.ReadLine();
                Console.WriteLine("Digite a matricula:");
                string matricula = Console.ReadLine();
                
                Console.WriteLine("Digite o sexo:");
                string sexo = Console.ReadLine();
                Console.WriteLine("Digite o salario:");
                string salario  = Console.ReadLine();

            }
            if (opcao == 2)
            {
                Console.WriteLine("CRM:");
                string crm = Console.ReadLine();
                Console.WriteLine("valor de hora extra:");
                string valorhoraextra = Console.ReadLine();
                Console.WriteLine("Especialidade");
                string especialidade = Console.ReadLine();
            }
            if(opcao == 3)
            {
                Console.WriteLine("funcao:");
                string funcao = Console.ReadLine();
            }


        }
    }
}