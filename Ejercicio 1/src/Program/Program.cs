using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            //v2 con constructores funciona
            AlmacenarLibro almacenolibro1 = new AlmacenarLibro("A", "7", libro1);
            AlmacenarLibro almacenolibro2 = new AlmacenarLibro("B", "3", libro2);
            //Almacenamiento.AlmacenarLibro("A", "7", libro1);
            almacenolibro1.Imprimir();
            almacenolibro2.Imprimir();
        }
    }
}
