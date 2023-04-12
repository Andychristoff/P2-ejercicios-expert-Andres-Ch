using System;
using System.Collections.Generic;
using SRP;

public class Sector
{
    public string Librarysector {get ; set;}
    public List <Shelve> shelves { get ; set; }
    public Sector (String sector)
    {
        this.Librarysector=sector;
        this.shelves= new List<Shelve>();
    }

    public void addshelve (Shelve shelve)
    {
        this.shelves.Add(shelve);
    }



}




