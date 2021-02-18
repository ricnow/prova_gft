using System;

namespace prova_gft
{
 class TerceiroDesafio 
 {
     static void Main(string[] args)
     {

        Console.WriteLine("Digite valor para x: ");
        int x = Convert.ToInt32( Console.ReadLine());
        Console.WriteLine("Digite valor para y: ");
        int y = Convert.ToInt32( Console.ReadLine());
        
        Soma soma = new Soma();
        Multiplicacao multiplicacao = new Multiplicacao();
        Divisao divisao = new Divisao();
        Subtracao subtracao = new Subtracao();
       
        Console.WriteLine("A Soma dos dois valores são: " + soma.efetuarOperacao(x, y));
        Console.WriteLine("A Divisão dos dois valores são: " + divisao.efetuarOperacao(x, y));
        Console.WriteLine("A Multiplicação dos dois valores são: " + multiplicacao.efetuarOperacao(x, y));
        Console.WriteLine("A Subtração dos dois valores são: " + subtracao.efetuarOperacao(x, y));  
       
        
     }
 }    
}