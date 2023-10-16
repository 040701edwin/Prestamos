using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos
{
    internal class Libro
    {
        //Atributos
        private string _tituloLibro;
        private string _autor;
        private int _Nejemplares;
        private int _NejemplaresPrestados;

        //Metodo constructor por defecto
        public Libro()
        {

        }
        //Metodo constructor por parametros
        public Libro(string tituloLibro, string autor, int nejemplares, int nejemplaresPrestados)
        {
            _tituloLibro = tituloLibro;
            _autor = autor;
            _Nejemplares = nejemplares;
            _NejemplaresPrestados = nejemplaresPrestados;
        }

        //Metodos getters y setters
        public string TituloLibro
        {
            get { return _tituloLibro; }
            set { _tituloLibro = value; }
        }
        public string autor
        {
            get { return _autor; }
            set { _autor = value; }
        }
        public int Nejemplares
        {
            get { return _Nejemplares; }
            set { _Nejemplares = value; }
        }
        public int NejemplaresPrestados
        {
            get { return _NejemplaresPrestados; }
            set { _NejemplaresPrestados = value; }
        }
        //Metodos
        public void Pedir(string m, ref int op)
        {
            Console.Write("{0}",m);
            op = int.Parse(Console.ReadLine());
        }
        public void Menu()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Opciones Disponibles");
            Console.WriteLine("::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("1- Prestar");
            Console.WriteLine("2- Regresar");
            Console.WriteLine("3- Disponibilidad");
            Console.WriteLine("4- Salir");
        }
        public void Libros()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Libos disponibles");
            Console.WriteLine("::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("1- Azul");
            Console.WriteLine("2- La Metamorfosis");
            Console.WriteLine("4- Salir");
        }
        


        


        

    }
}
