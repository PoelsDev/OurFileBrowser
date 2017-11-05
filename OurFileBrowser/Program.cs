using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace OurFileBrowser
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Geef argument!");
            } else
            {
                switch (args[0])
                {
                    case "-c":
                        ShowCurrentDirectory();
                        break;
                    case "-f":
                        ShowAllFilesInCurrentDirectory();
                        break;
                    default:
                        Console.WriteLine("Onbekend argument");
                        break;
                }
            }

        }
        static void ShowCurrentDirectory()
        {
            //Console.WriteLine("Current Directory:");
            Console.WriteLine("Current Directory:" + System.IO.Directory.GetCurrentDirectory());
            
        }
        static void ShowAllFilesInCurrentDirectory()
        {
            //string dir = System.IO.Directory.GetCurrentDirectory();
            //Console.WriteLine("Alle files in current directory");
            //Console.WriteLine("Alle files in de directory:" + System.IO.Directory.GetFiles(dir));
            string[] dirs = Directory.GetFiles(Environment.CurrentDirectory);
            foreach (string dir in dirs)
            {
                Console.WriteLine(Path.GetFileName(dir));
            }
            Console.WriteLine();
        }

        


    }
}