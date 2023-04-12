using System;
using System.Collections.Generic;
namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            Shelve shelve1= new Shelve ("shelve 1");
            Shelve shelve2= new Shelve ("shelve 2");
            Sector sector1= new Sector ("sector 1");
            Sector sector2= new Sector ("sector 2");
            sector2.addshelve(shelve1);
            Console.WriteLine($"el {sector2.Librarysector} tiene las siguientes estanterias: {sector2.shelves[0].LibraryShelve}");

            // Hice este console writeline para asegurarme que el programa se referia de forma correcta a las instancias
            // y a los metodos que utiliza
        }
    }
}