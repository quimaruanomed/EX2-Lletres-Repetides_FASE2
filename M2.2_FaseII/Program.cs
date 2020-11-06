using System;
using System.Collections.Generic;

namespace pruebaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> nameLet = new List<char>();

            nameLet.Add('j');
            nameLet.Add('o');
            nameLet.Add('a');
            nameLet.Add('q');
            nameLet.Add('u');
            nameLet.Add('i');
            nameLet.Add('n');
            nameLet.Add('a');
            int contador = 0;

            foreach (char let in nameLet)
            {
                contador++;
                if (let.Equals('a') || let.Equals('e') || let.Equals('i') || let.Equals('o') || let.Equals('u')) //Busca los carácteres(vocales) que están entre paréntesis en la lista de carácteres let
                {
                    Console.WriteLine("Vocal en posición: " + contador);
               
                }
                else
                {
                    Console.WriteLine("Consonante en posición: " + contador);
                }
                if(char.IsDigit(c: let)) //Busca numeros dentro de la lista let(contiene las letras del nombre)  si encuentra uno imprimirá el texto 
                {
                    Console.WriteLine("Los nombres de personas no contienen numeros");

                }
               


            }

        }
    }
}




