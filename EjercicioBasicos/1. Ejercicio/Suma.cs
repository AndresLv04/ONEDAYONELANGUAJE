namespace EjercicioBasicos
{
    class Suma
{
    //Atributos

    private double number1;
    private double number2;
    private double total;

    public Suma(int number1, int number2)
    {
        this.number1 = number1;
        this.number2 = number2;
        this.total = 0;
    }

    public void suma(){
        total = number1 + number2;
        Console.WriteLine("El total de la suma es: " + total);
    }
}
}
