using System;

/*
Escreva um programa onde o usuário digite World em uma variável “A” e Hello em uma variável “B”. A seguir (utilizando apenas atribuições entre variáveis) 
troque os seus conteúdos fazendo com que a  string que está em A passe para B e vice-versa. Ao final, escrever os valores que ficaram armazenados nas variáveis.
*/

namespace ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic a = "Word";
            string b = "Hello";

            a = (a + "|" + b).Split('|');

            b = a[0];
            a = a[1];
            Console.WriteLine($"a = {a} - b = {b}");
           

           


        }
    }
}
