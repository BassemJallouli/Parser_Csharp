using System;
using System.IO;

namespace Parser
{
 class Program 
    {         
        static void Main(string[] args)
        {
            string choice;
            string choicefile;
            string file = "file.txt";
            do
            {
                Console.WriteLine("Welcome to file service options");
                Console.WriteLine("Choose 1 to open file");
                Console.WriteLine("Choose 2 to edit file");
                Console.WriteLine("Choose 3 to end program");

                choice = Console.ReadLine();

                if (choice == 1)
                {
                    Console.WriteLine("Enter file name");
                    choicefile = Console.ReadLine();

                    if ( choicefile == "choice" )
                    {
                        Console.WriteLine("Enter option 2 to edit file");
                        
                    }
                    else
                    {
                        Console.WriteLine("We don't find file");
                    }
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Add text");
                    string text = Console.ReadLine();
                    File.WriteAllLines("file.txt", text);
                }

            } while ( choice != 3);       

        }
    }
}