namespace Ejercicio4
{
    class Libro
    {

        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _autor;
        public string Autor 
        {
            get { return myVar; }
            set { myVar = value; }
        }

        private int  _year;
        public int  Year{

            get { return _year; }
            set { _year = value; }
        }
        
        private int _cantidad;
        
        public int Cantidad{
            get {return _cantidad;}
            set {_cantidad = value}
        }

    
        public Libro(string title, string autor, int year, int cantidad)
        {
            Title = title;
            Autor = autor;
            Year = year;
            Cantidad = cantidad;
        }

        public string mostrarInfoLibro(){
            return $"Titulo: {_title} 
                    Año de publicación {_year}
                    Autor: {_autor}
                    Cantidad disponible: {_cantidad}"
        }
        
    }
}