using System;

namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Idade:");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Salário:");
            float salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Estado Civil:");
            string EsCivil = Console.ReadLine().Substring(0).ToLower();

            if (nome == "")
            {
                Console.WriteLine("nome inválido");
            }
            if (idade < 0 && idade > 150)
            {
                Console.WriteLine("idade inválido");
            }
            if (salario < 1)
            {
                Console.WriteLine("salário inválido");
            }
            if (EsCivil != "s" && EsCivil != "c" && EsCivil == "v" && EsCivil != "d")
            {
                Console.WriteLine("Estado Civil inválido");
            }
        }
    }
}
