using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            //book1.ShelveBook("A","7");
            //book2.ShelveBook("B","3");

            ShelveBook shelve1 = new ShelveBook("A", "7");
            ShelveBook shelve2 = new ShelveBook("B", "3");
            ShelveBook shelve3 = new ShelveBook("B", "3");
            
            Console.WriteLine();

            //Probando el método agregarLibroShelveBook e imprimirDicc
            shelve1.agregarLibroShelveBook(book1);
            shelve2.agregarLibroShelveBook(book2);
            shelve3.agregarLibroShelveBook(book2); //espacio ocupado, por lo que no se puede agregar el libro
            shelve1.imprimirDicc();

            Console.WriteLine();

            //Probando el método buscarLibro
            Console.WriteLine(shelve1.buscarLibro(book2.Title));
            Book book3 = new Book("Hola Mundo","Anonimo","001-034");
            Console.WriteLine(shelve1.buscarLibro(book3.Title)); //libro  no agregado, por lo que no se encuentra

             Console.WriteLine();
        }
    }
}