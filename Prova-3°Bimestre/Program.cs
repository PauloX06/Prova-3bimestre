using Prova_3_Bimestre.classes;
using System;

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

                Console.WriteLine("Digite o nome:");
                Console.WriteLine("Digite o cpf: ");
                Console.WriteLine("Digite a matricula:");

            }

        }
    }
}