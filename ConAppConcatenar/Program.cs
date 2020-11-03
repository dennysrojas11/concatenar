using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace ConAppConcatenar
{
    class Program
    {
        static void Main(string[] args)
        {
            String cadena, frase=null;

            Console.WriteLine("Programa que concatena 3 cadenas de texto");
            for (int i = 1; i <= 3; i++) {
                Console.WriteLine("Ingrese la cadena: "+i);
                cadena = Console.ReadLine();
                if (validar(cadena) == true)
                {
                    frase += cadena;
                }
                else {
                    Console.WriteLine("Solo se permite el ingreso de texto");
                    i--;
                }
                
            }
            Console.WriteLine("Cadena concatenada: "+frase);
            
        }
        
        public static bool validar(string cadena) {
            bool l = false;
            for (int j = 0; j < cadena.Length; j++) {
                if (char.IsLetter(cadena, j))
                {
                    l = true;
                }
                else {
                    l = false;
                    j = cadena.Length;
                }
            }
            return (l);
        }
    }
}
