using System;

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repetir = true;
            while (repetir == true)
            {
                Console.WriteLine("Nome de usuário:");
                string usuario = Console.ReadLine();
                Console.WriteLine("Senha:");
                string senha = Console.ReadLine();
                if (senha == usuario)
                {
                    Console.WriteLine("ERRO" + "\n" + "insira novamente");
                }
                else
                {
                    repetir = false;
                }
            }

        }
    }
}
