namespace ServidorOpcion1
{
    class Program
    {
        static void Main(string[] args)
        {
            Servidor servidor = new Servidor(5000);
            servidor.Start();
        }
    }
}