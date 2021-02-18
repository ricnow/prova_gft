using System;

namespace prova_gft
{
    class SegundoDesafio
    {
        private const string V = "Incomoda, ";

        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número inteiro: ");
            int numero = Convert.ToInt32( Console.ReadLine());
            string palavra = "Incomoda ";
            for(int i = 0; i < numero; i++)
            {
                Console.Write(palavra);
            }
            Console.Write($"muito mais");
        }
    }        
}