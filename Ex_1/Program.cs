using System;

namespace Exercícios_repetição_e_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repetir = true;
            do
            {
                Console.WriteLine("insira uma nota de 0 a 10");
                float nota = float.Parse(Console.ReadLine());

                if (nota >= 0 && nota <= 10 )
                {
                    repetir = false;
                } else {
                    Console.WriteLine("número inválido");
                }
            } while (repetir == true);
        }
    }
}
