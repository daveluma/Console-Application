using System;
using System.IO;

namespace ConsoleApplication
{
    class PersonInfo
    {
        static void Main(string[] args)
        {
            //Ask and recieve first and last name
            Console.WriteLine("What is your first name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lName = Console.ReadLine();
            string outName = $"Your first name is " + name + " and last name is "+lName +".";
            Console.WriteLine(outName);

            //where to create and write the new text file
            string fileName = @"C:\Users\Public\nameLast.txt";

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                // Create a new file     
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine(outName);   
                }

            }
            //catch if there is a problem writing to a textfile
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }

            /* String read from a the text file that was just created */
            string text = System.IO.File.ReadAllText(@"C:\Users\Public\nameLast.txt");

            //Output the captured string from the textfile to the Console
            Console.WriteLine($"This text is from the textfile: {text}");
        }
    }
}
