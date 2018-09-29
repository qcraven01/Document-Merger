using System;
using System.IO;

namespace Document_Merger
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Document Merger    ");
            Console.WriteLine("Enter the name of the first text file:    ");

            if (File.Exists("TextFile1.txt"))
            {
                Console.WriteLine("The file exists");
                string TextFile1 = Console.ReadLine();
            }
            else{
                Console.WriteLine("This file does not exist. Please re-enter the name for the first text file:   ");
                string TextFile1 = Console.ReadLine();
            }

            Console.WriteLine("Now enter the name of the second text file:    ");
    
            if (File.Exists("TextFile2.txt"))
            {
                Console.WriteLine("The file exists");
                string TextFile2 = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("This file does not exist. Please re-enter the name for the second text file:   ");
                string TextFile2 = Console.ReadLine();
            }
            string[] TextFile1 = File.ReadAllLines (MainFile.txt);
        }
         
    }
}
