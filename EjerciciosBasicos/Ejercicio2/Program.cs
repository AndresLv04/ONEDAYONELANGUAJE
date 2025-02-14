namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura = double.Parse(Console.ReadLine());
            Rectangulo objRectangulo = new (3,altura);
            System.Console.WriteLine(objRectangulo.CalcularArea());
            System.Console.WriteLine(objRectangulo.CalcularPerimetro());

        }
    }
}
