using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ServidorOpcion1
{
    public class Servidor
    {
        private TcpListener _servidor;
        private int _puerto;

        public Servidor(int puerto)
        {
            puerto = puerto;
            _servidor = new TcpListener(IPAddress.Any, puerto); //Permite escuchar las interfaces de red
        }

        private void AtenderCliente(TcpClient cliente)
        {
            NetworkStream ns = cliente.GetStream(); //Obtiene el flujo de datos
            byte[] buffer = new byte[1024]; //Buffer para recibir los datos
            int LecturaByte = ns.Read(buffer, 0, buffer.Length); //Lee los datos del cliente

           
            Console.WriteLine("Bienvenido al servidor");
            string mensaje = Encoding.UTF8.GetString(buffer, 0, LecturaByte); //Convierte los datos a string
            Console.WriteLine("Mensaje recibido: {0}", mensaje);
           
            cliente.Close();
        }
        public void Start()
        {
            _servidor.Start();
            Console.WriteLine("Servidor iniciado en el puerto {0}", _puerto);
            while (true) //Ciclo infinito para atender clientes
            {
                TcpClient cliente = _servidor.AcceptTcpClient(); //Espera a que un cliente se conecte
                Console.WriteLine("Cliente conectado");
                AtenderCliente(cliente); //Atiende al cliente
            }
        }

        public void Stop()
        {
            _servidor.Stop(); //Detiene el servidor
            Console.WriteLine("Servidor detenido");
        }

        
    }
}
