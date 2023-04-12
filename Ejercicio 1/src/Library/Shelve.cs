using System;
using System.Collections.Generic;
namespace SRP
{

public class Shelve
{
public string LibraryShelve { get ; set; }
public List <Book> libros { get ; set; }
public Shelve(String shelve)
    {
    this.LibraryShelve = shelve;
    this.libros=new List<Book>();
    }

public void Addbook (Book book)
    {
        this.libros.Add(book);
    }
}   
}