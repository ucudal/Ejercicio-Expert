using System;
using System.Collections.Generic;
using System.Linq;


namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
       // public string LibrarySector { get ; set; }
        //public string LibraryShelve { get ; set; }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        
        public override string ToString(){
            return $"[{String.Join(',',(this.Title, this.Author, this.Code))}]";
        } 

        /*public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }*/

    }


    public class ShelveBook{

        //private List<Book> libros = new List<Book>();
        public static Dictionary<Book, (string, string)> dicc = new Dictionary<Book, (string,string)>(){};

        public string LibrarySector { get ; set; } //sector
        public string LibraryShelve { get ; set; } // shelve 7

        

        public ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }

        //método que agrega un libro a la estanteria 
        public void agregarLibroShelveBook(Book libro/*, string sector, string shelve*/){
            List<Book> keys = dicc.Keys.ToList();
            List<(string,string)> values = dicc.Values.ToList();

            (string, string) t1 = (this.LibrarySector, this.LibraryShelve);
            if (values.Contains(t1)){
                Console.WriteLine($"Ya esta ocupado el espacio {t1}");
            }
            else{
                dicc.Add(libro, t1);
            }
        }

        public string buscarLibro(Book libro){
            List<Book> keys = dicc.Keys.ToList();
            List<(string,string)> values = dicc.Values.ToList();
            int i = 0;
            bool salir = false;
            while ( (i < keys.Count) && (!salir) ){
                if (libro != keys[i]){
                    i++;
                }
                else{
                    salir = true;
                }
            }
            string salida = "";
            if (i < keys.Count){
                salida = $"El libro {libro.Title} se encuentra en {values[i]}";
            }
            else{
                salida = $"El libro {libro.Title} no se encuentra.";
            }

            return salida;
        }


        public override string ToString()
        {
            return $"Sector: {this.LibrarySector} Shelve: {this.LibraryShelve}";
        }

        public void imprimirDicc(){
            
            Console.WriteLine("ELEMENTOS DEL DICCIONARIO :");
            /*foreach(KeyValuePair<Book, (string,string)> item in dicc){
                Console.WriteLine($"{item.Key} : {item.Value}");
            }*/
            foreach (var kvp in dicc) {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
          
        }
    }
}
/*Para que la clase "Libro" cumpla con el principio SRP se debe hacer otra clase llamada "ShelveBook". 
En esta útima se va a encontrar todos los métodos y atributos relacionados con la esatnteria. */

