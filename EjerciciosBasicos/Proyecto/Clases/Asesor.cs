using  Proyecto.Interfaces;

namespace Proyecto.Clases
{
    public class Asesor : ITrabajador
    {
        public double Ventas {get ; set;}
        public Asesor(double ventas)
        {
            Ventas = ventas;
        }

        public double Pay()
        {
            return Ventas * 0.30;
        }
    }
}