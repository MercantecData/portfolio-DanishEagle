using System;

namespace Library
{
    class Menu
    {
        public static void MainMenu()
        {
            Console.Clear();
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

        //time stamp for borrowing books and returning them, will later implement a way to also show when the books need to be returned 
        public static string GetTimeStamp(DateTime value)
        {
            return value.ToString("dd/MM/yyyy/HH:mm");
        }

        //Note to self: instead of asking for which book, provide a list and let customer pick what book they want to borrow
        public static void BorrowBook()
        {
            Console.Clear();
            string timeStamp = GetTimeStamp(DateTime.Now); 
            Console.WriteLine("Which book would you like to borrow: ");
            string bookToBorrow = Console.ReadLine();
            Console.WriteLine("You've borrowed " + bookToBorrow + " at " + timeStamp);

            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Press 1 to go back to menu\nPress any other button to close program");
            string yes = Console.ReadLine();
            if (yes == "1")
            {
                MainMenu();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        public static void SearchBook()
        {
            Console.Clear();
            Console.WriteLine("Search for book here: ");
            string searchInput = Console.ReadLine();

            if (searchInput == "The Luminous Dead") 
            {
                //more options to show if its in stock or not 
                Console.WriteLine("The book is in stock / is not in stock");
            } 
            else 
            {
                Console.WriteLine("No book was found.");
            }

            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Press 1 to go back to menu\nPress 2 to search for another book\nPress any other button to close program");
            string yes = Console.ReadLine();
            if (yes == "1")
            {
                MainMenu();
            } 
            else if (yes == "2") 
            {
                SearchBook();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        public static void ReturnBook()
        {
            string timeStamp = GetTimeStamp(DateTime.Now);
            Console.Clear();
            Console.WriteLine("Which book would you like to return: ");
            string bookToReturn = Console.ReadLine();
            Console.WriteLine("You've returned: " + bookToReturn + " at " + timeStamp);
            
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Press 1 to go back to menu\nPress any other button to close program");
            string yes = Console.ReadLine();
            if (yes == "1")
            {
                MainMenu();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
