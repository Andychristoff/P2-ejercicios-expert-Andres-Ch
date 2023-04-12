using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        

    }
}
// Este codigo no cumple con el principio SRP y podria ser escrito de una forma mas eficiente. Esto se debe 
//a que la clase libro contiene informacion que puede ser irrelevante para el objeto, y que podria ser asignada
// a otra clase distinta.