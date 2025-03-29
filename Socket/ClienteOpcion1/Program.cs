namespace ClienteOpcion1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("127.0.0.1", 5000);
            cliente.Conectar();
        }

    }
}
