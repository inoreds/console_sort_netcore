using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleTest
{
    class Program
    {
        /*@author : mochamad rifai idris
         *@Project: sorted name in txt
         */
        static void Main(string[] args)
        {
            List<string> unsorted_data = new List<string>();
            string check_file = "unsorted-names-list.txt";
            if (!File.Exists(check_file))
                initialCreate();
            
            try
            {
                int counter = 0;
                string line;

                System.IO.StreamReader file = new StreamReader("usorted-names-list.txt");
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

        public static void initialCreate()
        {
            List<string> unsorted_data = new List<string>()
            { 
                "Orson Milka Iddins",
                "Erna Dorey Battelle",
                "Flori Chaunce Franzel",
                "Odetta Sue Kaspar",
                "Roy Ketti Kopfen",
                "Madel Bordie Mapplebeck",
                "Selle Bellison",
                "Leonerd Adda Mitchell Monaghan",
                "Debra Micheli",
                "Hailey Annakin",
                "Leonerd Adda Micheli Monaghan",
                "Avie Annakin"
            };
            using (StreamWriter outputFile = new StreamWriter("usorted-names-list.txt"))
            {
                foreach (string data in unsorted_data)
                    outputFile.WriteLine(data);
            }
        }
    }
}
