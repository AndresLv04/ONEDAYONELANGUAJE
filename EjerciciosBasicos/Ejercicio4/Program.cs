using System;
namespace Ejercicio4
{
    class Program
    {
     static void Main(string[] args)
     {
        const int year = 2025;
        

        Console.WriteLine("Escribe tu edad: ");
        string input = Console.ReadLine();

        int age;
        if(int.TryParse(input, out age)){
            int a = year - age;
            System.Console.WriteLine("Su año de nacimiento es: " + a);
        }
        else
        {
            System.Console.WriteLine("La entrada no es valida");
        }

     }   
    }
}
