using System;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Books> BookList = new List<Books>();
            BookList.Add(new Books("The Luminous Dead", "Nanme Namesom", "Dystorpian"));
            BookList.Add(new Books("Harry Potter", "JK Rowling", "Fantasy"));
            BookList.Add(new Books("BookTitle", "Authors Name", "Drama"));

            

            Menu.MainMenu();            
        }

    }
}
