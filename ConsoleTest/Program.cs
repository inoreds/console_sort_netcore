using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleTest
{
    class Program
    {
        /*@author : mochamad rifai idris
         *@Project: sorted name in txt
         *@Coc path : please check in debug folder
         */
        static void Main(string[] args)
        {
            List<string> unsorted_data = new List<string>();
            try
            {
                int counter = 0;
                string line;
  
                System.IO.StreamReader file = new System.IO.StreamReader("unsorted-names-list.txt");
                while ((line = file.ReadLine()) != null)
                {
                    unsorted_data.Add(line);
                    counter++;
                }

                unsorted_data.Sort();
                foreach (string data in unsorted_data)
                {
                    Console.WriteLine(data);
                }
                using (StreamWriter outputFile = new StreamWriter("sorted-names-list.txt"))
                {
                    foreach (string data in unsorted_data)
                        outputFile.WriteLine(data);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

        }
    }
}
