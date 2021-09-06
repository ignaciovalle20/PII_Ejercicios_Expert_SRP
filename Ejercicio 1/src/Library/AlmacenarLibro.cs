using System;

namespace SRP
{
    /*
    Separamos las clases Libro y almacenar libro porque almacenar libro no cumple la misma funcion que Libro
    esta violando el principio SRP
    */
    public class AlmacenarLibro
    {

        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }
        
        public Libro Item {get; set;}
        public AlmacenarLibro(String sector, String estante, Libro libro)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
            this.Item = libro; 
        }

    }
}
