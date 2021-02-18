using System;

namespace prova_gft
{
    class Program
    {
        static void Main(string[] args)
        {
            const int contador = 3;
            int[] numero = new int[contador];
            int menor = 0, maior=0;
            Console.WriteLine("Digite o Três Números: ");

            for(int i = 0; i < contador; i++)
            {
                Console.WriteLine( ( i + 1 ) + "º número:" );
                numero[i] = Convert.ToInt32( Console.ReadLine() );

                if( i == 0 )
                    {
                        menor = numero[0];
                        maior = numero[0];
                    }

                    if( numero[i] < menor )
                    {

                        menor = numero[i];
                    }
                    else if( numero[i] > maior )
                    {
                        maior = numero[i];
                    }
            }
            Console.WriteLine( "O menor número é:" + menor );
            Console.WriteLine( "O maior número é:" + maior );
        }
    }        
}
