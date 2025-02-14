using System;
{
    
}
namespace Ejercicio1
{
    //cd EjerciciosBasicos/Ejercicio1 luego el dotnet
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante objEstudiante = new ("Andres", "Lopez")
            {
                Note1 = 8.0,
                Note2 = 7.5,
                Note3 = 5.5
            };
            Console.WriteLine(objEstudiante.Name);
            objEstudiante.MostrarEstado();
        }
    }
}

