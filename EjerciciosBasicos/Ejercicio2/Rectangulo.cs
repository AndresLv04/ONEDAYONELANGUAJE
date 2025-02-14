namespace Ejercicio2
{
    class Rectangulo
    {
        private double _base;
        public double Base
        {
            get { return _base; }
            set { _base = value; }
        }

        private double _altura;
        public double Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }
        
        public Rectangulo(double baseR, double altura)
        {
            Base = baseR;
            Altura = altura;
        }

        public String CalcularArea(){
            double area = _base * _altura;
            return $"El area del rectangulo es: {area}";
        }
        
        public String CalcularPerimetro(){
            double perimetro = 2 * _base + 2 * _altura;
            return $"El perimetro del rectangulo {_base} x {_altura} es: {perimetro}";
        }
    }
}