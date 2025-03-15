namespace Ejercicio1
{
    class Estudiante
    {
        private string _name;
       
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private double _note1;

        public double Note1
        {
            get { return _note1; }
            set { _note1 = value; }
        }
        
        private double _note2;

        public double Note2
        {
            get { return _note2; }
            set { _note2 = value; }
        }

        private double _note3;

        public double Note3
        {
            get { return _note3; }
            set { _note3 = value; }
        }
        
        //Constructor
        public Estudiante(string name, string lastName)
        {
            this._name = name;
            LastName = lastName;
        }

        public double CalcularPromedio(){
            return (Note1 + Note2 + Note3) / 3;
        }

        public void MostrarEstado(){
            if (CalcularPromedio() >= 6)
            {
                Console.WriteLine("Estudiante: " + Name + " usted aprobó con un promedio de: " + CalcularPromedio());
            }
            else
            {
                Console.WriteLine("Estudiante: " + Name + " lo lamento no aprobo, ya que tuvo un promedio de: " + CalcularPromedio());
            }
        }

        
    }
}