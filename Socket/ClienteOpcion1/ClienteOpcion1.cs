using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClienteOpcion1
{
    public class Cliente
    {
        private string ipServidor;
        private int puertoServidor;
        private TcpClient cliente;

        public Cliente(string ipServidor, int puertoServidor)
        {
            this.ipServidor = ipServidor;
            this.puertoServidor = puertoServidor;
            cliente = new TcpClient(); // Se crea el cliente
        }

        public void Conectar()
        {
            cliente.Connect(ipServidor, puertoServidor); // Se conecta al servidor
            NetworkStream ns = cliente.GetStream(); // Se obtiene el stream de red
            string? mensaje = Console.ReadLine(); // Se lee el mensaje a enviar
            if (mensaje != null)
            {
                byte[] datos = Encoding.ASCII.GetBytes(mensaje); // Convierte el mensaje a bytes
                ns.Write(datos, 0, datos.Length); // Se envía el mensaje al servidor 
                Console.WriteLine("Mensaje enviado");
            }
            else
            {
                Console.WriteLine("No se puede enviar un mensaje nulo");
            }
            ns.Close(); // Se cierra el stream de red
        }
    }
}