using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int ultimoElemento = 1;
            int penultimoElemento = 0;

            bool sequencial = true;
            while (sequencial == true)
            {
                int elemento = ultimoElemento + penultimoElemento;
                Console.WriteLine(elemento);
                
                penultimoElemento = ultimoElemento;
                ultimoElemento = elemento;

                if (elemento > 500)
                {
                    sequencial = false;
                }
            }

        }
    }
}
