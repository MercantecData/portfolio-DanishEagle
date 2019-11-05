﻿using System;

namespace Library
{
    class Menu
    {
        Books newBook = new Books("The Luminous Dead", "Name Nameson", "Fantasy");

        public static void MainMenu()
        {
            Console.WriteLine("Menu\n" +
                "1: Borrow Book\n" +
                "2: Search Book\n" +
                "3: Return Book\n" +
                "4: Extend loan of book (Not yet a function)\n" +
                "5: Close");

            Console.WriteLine("Please pick an option: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                BorrowBook();
            } 
            else if (input == "2")
            {
                SearchBook();
            }
            else if (input == "3")
            {
                ReturnBook();
            } 
            else if (input == "4")
            {
                //Extend loan
            }
            else if (input == "5")
            {
                Environment.Exit(0);
            }
        }

        public static void BorrowBook()
        {
            Console.Clear();
            Console.WriteLine("Which book would you like to borrow: ");
            string bookToBorrow = Console.ReadLine();
        }

        public static void SearchBook()
        {
            Console.Clear();
            Console.WriteLine("Search for book here: ");
            string searchInput = Console.ReadLine();

            if (searchInput.Contains("The Luminous Dead"))
            {
                Console.WriteLine("The book is in stock / is not in stock");
            } 
            else 
            {
                Console.WriteLine("No book was found.");
            }
        }

        public static void ReturnBook()
        {
            Console.Clear();
            Console.WriteLine("Which book would you like to return: ");
            string bookToReturn = Console.ReadLine();
        }
    }
}
