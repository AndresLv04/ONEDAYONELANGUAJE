using Proyecto.Interfaces;
using Proyecto.Clases;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            t = new ITrabajador[2];
            
            t[1] = new Asesor(10000);
            t[2] = new Operario(10);
        
        }
    }
}
