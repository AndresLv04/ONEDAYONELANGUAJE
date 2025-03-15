using Proyecto.Interfaces;

namespace Proyecto.Clases
{
    public class Operario : ITrabajador
    {
        public const int VALOR_HORA = 9000;
        public double Hours {get ; set;}

        public Operario(double hours)
        {
            Hours = hours;
        }

        public double Pay()
        {
            return Hours * VALOR_HORA;
        }
    }
}